using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dapper;
using SiscomData.Models;
using SiscomData.DTOS;

namespace SiscomData.Controllers
{
    public class ProcesoRentasRecetasDpController : ControllerBase
    {
        private readonly BD_SISCOMV2_301Context db;
        private const string OutputFilePath = @"C:\archivos\GeneratedQueries.sql";
        private const string CodigoLogFilePath = @"C:\archivos\ProcessedCodigos.log";

        public ProcesoRentasRecetasDpController(BD_SISCOMV2_301Context context)
        {
            db = context;
        }

        static string queryPrincipal = @"
            SELECT 
                NULL AS Sucursal_Renta,
                DP.Cliente AS Cliente_Renta,
                NULL AS Codigo_Renta,
                NULL AS CodigoEnvases_Renta,
                DP.TipoServicio AS TipoServicio_Receta,
                DP.FolioFactura AS FolioFactura_Receta,
                'No coincide' AS CoincideCodigo
            FROM  
                [dbo].[TMCOOXRECETADP] DP
            LEFT JOIN  
                [dbo].[TDCOOXRENTASCTE] R
            ON  
                ISNUMERIC(DP.TipoServicio) = 1 
                AND R.Codigo = CAST(DP.TipoServicio AS INT)
                AND R.Cliente = DP.Cliente
            WHERE 
                R.Codigo IS NULL
                AND DP.Mes = @Mes 
                AND DP.Anio = @Anio
                AND ISNUMERIC(DP.TipoCte) = 1 
                AND CAST(DP.TipoCte AS INT) = @ClienteId
            UNION ALL

            SELECT 
                R.Sucursal AS Sucursal_Renta,
                R.Cliente AS Cliente_Renta,
                R.Codigo AS Codigo_Renta,
                R.CodigoEnvases AS CodigoEnvases_Renta,
                DP.TipoServicio AS TipoServicio_Receta,
                DP.FolioFactura AS FolioFactura_Receta,
                'Coincide' AS CoincideCodigo
            FROM  
                [dbo].[TDCOOXRENTASCTE] R
            INNER JOIN  
                [dbo].[TMCOOXRECETADP] DP 
            ON  
                ISNUMERIC(DP.TipoServicio) = 1 
                AND R.Codigo = CAST(DP.TipoServicio AS INT)
                AND R.Cliente = DP.Cliente
            WHERE 
                DP.Mes = @Mes 
                AND DP.Anio = @Anio
                AND ISNUMERIC(DP.TipoCte) = 1 
                AND CAST(DP.TipoCte AS INT) = @ClienteId
            ORDER BY 
                Cliente_Renta, 
                Codigo_Renta;";

        public async Task<bool> InsertaOActualizaRentasVsRecetasDP(string cliente, int anio, int mes, System.Data.Common.DbConnection connection)
        {
            var discrepancies = new List<object>();

            DateTime today = DateTime.Now;
            DateTime lastMonth = today.AddMonths(-1);
            int day = 30;

            DateTime fechaUltRentaDate = new DateTime(lastMonth.Year, lastMonth.Month, Math.Min(day, DateTime.DaysInMonth(lastMonth.Year, lastMonth.Month)));
            string fechaUltRenta = fechaUltRentaDate.ToString("yyyy-MM-dd HH:mm:ss");

            // Obtener rentas del cliente
            var rentas = db.Tdcooxrentasctes
                .Where(x => x.Cliente.ToString() == cliente)
                .ToList();

            // Obtener recetas del cliente
            var recetas = db.Tmcooxrecetadps
                .Where(x => x.Cliente.ToString() == cliente && x.DpfechaInicio != null && x.DpfechaFin != null && x.Anio == anio && x.Mes == mes)
                .ToList();

            //Caso 1: Cuando no hay rentas y existe una receta 
            if (rentas.Count == 0 && recetas.Count > 0)
            {
                string codigoEnvase = db.Tmcoenv01s.FirstOrDefault(x => x.EnvCont == 1).Codigo.ToString();

                string sqlInsert = $@"INSERT INTO Tdcooxrentascte (Sucursal, Cliente, Codigo, FechaUltRenta, CodigoEnvases, DotacionFinal, FolioFactura, FolioAltaRenta, ImprimirFactura, Usuario, FechaAudit, Observaciones, Pantalla) VALUES ('{recetas.FirstOrDefault()?.Sucursal}', '{recetas.FirstOrDefault()?.Cliente}', {recetas.FirstOrDefault()?.TipoServicio}, '{fechaUltRenta}', {codigoEnvase}, {1}, {recetas.FirstOrDefault()?.FolioFactura ?? 0}, 0, 0, 'System', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', 'Auto: Actualiza Renta', 'CteFirma RR/RC');";
                await connection.ExecuteAsync(sqlInsert);
                return true;
            }

            //Caso 2: Cuando existe 1 vs 1 actualiza
            else if (rentas.Count == 1 && recetas.Count == 1)
            {
                if (rentas.FirstOrDefault().Codigo.ToString() != recetas.FirstOrDefault().TipoServicio.ToString())
                {

                    string updateSql = $@"UPDATE Tdcooxrentascte SET Codigo = {recetas.FirstOrDefault().TipoServicio},FechaUltRenta = {fechaUltRenta}, FechaAudit = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', Observaciones = 'Actualizado 1vs1' WHERE Cliente = '{recetas.FirstOrDefault().Cliente}' AND Codigo = {rentas.FirstOrDefault().Codigo};";
                    await connection.ExecuteAsync(updateSql);

                    // Escribir la consulta de actualización en el archivo
                    await System.IO.File.AppendAllTextAsync(OutputFilePath, updateSql + Environment.NewLine);
                }
                return true;
            }
            //Caso 3: Cuando hay varias recetas y menos rentas  
            else if (recetas.Count > 1)
            {
                // Rentas y recetas desiguales
                var rentasOnly = rentas.Where(x => x.Cliente.ToString() == cliente)
                .Select(x => x.Codigo)
                .ToList();

                var recetasOnly = recetas.Where(x => x.Cliente.ToString() == cliente && x.DpfechaInicio != null && x.DpfechaFin != null)
                .Select(x => Convert.ToInt32(x.TipoServicio))
                .ToList();

                if (rentasOnly.Any() || recetasOnly.Any())
                { 

                    var dotacionObj = db.Tmcoenv01s.Where(x => x.Cliente == Convert.ToInt32(cliente) && x.EnvCont > 0).ToList();

                    foreach (var itemDotacion in dotacionObj)
                    {
                        var existeEnRentas = db.Tdcooxrentasctes.Any(x => x.Cliente == itemDotacion.Cliente && x.CodigoEnvases == itemDotacion.Codigo);

                        if (!existeEnRentas)
                        {
                            var prodObj = db.Tmcooxproductos.FirstOrDefault(x => x.Codigo == itemDotacion.Codigo);

                            if (prodObj != null)
                            {
                                string sqlInsert = $@"INSERT INTO Tdcooxrentascte (Sucursal, Cliente, Codigo, FechaUltRenta, CodigoEnvases, DotacionFinal, FolioFactura, FolioAltaRenta, ImprimirFactura, Usuario, FechaAudit, Observaciones, Pantalla) VALUES ('{itemDotacion?.Sucursal}', '{itemDotacion.Cliente}', {prodObj.CodigoRenta}, '{fechaUltRenta}', {prodObj.Codigo}, {itemDotacion.EnvCont}, {0}, 0, 0, '{itemDotacion.Usuario}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', 'Auto: Actualiza Renta', '');";
                                await connection.ExecuteAsync(sqlInsert);

                                await System.IO.File.AppendAllTextAsync(OutputFilePath, sqlInsert + Environment.NewLine);
                            }
                        }
                    }
                    return true; 
                }
            }

            return true;
        }


        [HttpPost]
        [Route("ActualizaSeguimientoDotacion")]
        public async Task<IActionResult> ActualizaSeguimientoDotacion([FromBody] SeguimientoRequest request)
        {
            try
            {
                if (request.Option == "pacientes")
                {
                    if (request.Pacientes == null || request.Pacientes.Count == 0)
                    {
                        return BadRequest(new { Error = "El valor proporcionado no puede ser nulo o vacío." });
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(request.Value))
                    {
                        return BadRequest(new { Error = "El valor proporcionado no puede ser nulo o vacío." });
                    }
                }
                 
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    var logEntries = new List<string>();
                    logEntries.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Iniciando Actualización: Opción - {request.Option} ");

                    //Proceso uno: Dotacion y seguimiento
                    IEnumerable<SeguimientoDotacionDto> resultQuery = null;
                    if (request.Option == "pacientes")
                    {
                        resultQuery = (from env in db.Tmcoenv01s
                                       join seg in db.Tdcooxseguimientoequipos on env.Cliente equals seg.Cliente
                                       join cli in db.Tmcooxclientes on seg.Cliente equals cli.Cliente
                                       join gral in db.Tmcoctgrals on cli.Cliente equals gral.Cliente
                                       join prod01 in db.Tmcoinprod01s on env.Codigo equals prod01.Codigo
                                       join prod in db.Tmcooxproductos on prod01.Codigo equals prod.Codigo
                                       where seg.Codigo == env.Codigo
                                           && seg.EnvCont > env.EnvCont
                                           && env.EnvProp == 0
                                           && gral.TipoCte == "O"
                                           && request.Pacientes.Contains(cli.Cliente)
                                       select new SeguimientoDotacionDto
                                       {
                                           Cliente = env.Cliente,
                                           Codigo = env.Codigo.ToString(),
                                           EnvContEnv = env.EnvCont,
                                           EnvContSeg = seg.EnvCont
                                       }).ToList(); // Materialize the query
                    }
                    else
                    {
                        resultQuery = await connection.QueryAsync<SeguimientoDotacionDto>(
                            GetQueryForOption(request.Option),
                            new { valor = request.Value }
                        );
                    }

                    foreach (SeguimientoDotacionDto item in resultQuery)
                    {
                        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        logEntries.Add($"{timestamp} - Cliente: {item.Cliente}, Codigo: {item.Codigo}, EnvContEnv: {item.EnvContEnv}, EnvContSeg: {item.EnvContSeg}");

                        if (item.EnvContEnv != item.EnvContSeg)
                        { 
                            var dotacionResp = await db.Tdcooxseguimientoequipos
                                .FirstOrDefaultAsync(x => x.Cliente == item.Cliente && x.Codigo == int.Parse(item.Codigo));

                            await AddToSeguimientoEquipoRespAsync(dotacionResp);
                             
                            if (dotacionResp?.FechaBaja == null)
                            {
                                await connection.ExecuteAsync(GetUpdateQueryConFecha(), new
                                {
                                    Dotacion = item.EnvContEnv,
                                    Cliente = item.Cliente,
                                    Codigo = item.Codigo,
                                    Fecha = dotacionResp.FechaAudit
                                });
                            }
                            else
                            {
                                await connection.ExecuteAsync(GetUpdateQuery(), new
                                {
                                    Dotacion = item.EnvContEnv,
                                    Cliente = item.Cliente,
                                    Codigo = item.Codigo
                                });
                            }

                            logEntries.Add($"{timestamp} - Actualizado - Cliente: {item.Cliente}, Codigo: {item.Codigo}, Nuevo EnvCont: {item.EnvContEnv}");
                        }
                    }

                    //Proceso dos: Log Rentas vs Recetas
                    IEnumerable<SeguimientoDotacionDto> resultQueryRentasVsRecetas = null;
                    if (request.Option == "pacientes")
                    {
                        resultQueryRentasVsRecetas = db.Tmcooxclientes
                            .Where(cli => request.Pacientes.Contains(cli.Cliente))
                            .Select(cli => new SeguimientoDotacionDto
                            {
                                Cliente = cli.Cliente,
                                Codigo = cli.Clave
                            })
                            .ToList(); // Materialize EF query
                    }
                    else
                    {
                        resultQueryRentasVsRecetas = await connection.QueryAsync<SeguimientoDotacionDto>(
                            GetQueryForOptionRentasRecetas(request.Option),
                            new { valor = request.Value }
                        );
                    }
                     
                    foreach (SeguimientoDotacionDto item in resultQueryRentasVsRecetas)
                    {
                        bool esAseguradora = db.Tmcooxclientes
                            .Any(x => x.TipoParticular == "AS" && x.Cliente == item.Cliente);

                        if (esAseguradora)
                        {
                            await InsertaOActualizaRentasVsRecetasDP(item.Cliente.ToString(), request.anio, request.mes, connection);
                        }
                    }

                    // Save Logs
                    await System.IO.File.AppendAllLinesAsync(CodigoLogFilePath, logEntries);

                    return Ok(new
                    {
                        Message = "Actualización completada con éxito.",
                        LogFilePath = CodigoLogFilePath
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message
                });
            }
        }



        private async Task AddToSeguimientoEquipoRespAsync(Tdcooxseguimientoequipo seguimiento)
        {
            try
            {
                var existingRecord = db.Tdcooxseguimientoequiposresps
                    .FirstOrDefault(x => x.Cliente == seguimiento.Cliente && x.Codigo == seguimiento.Codigo);

                if (existingRecord == null)
                {
                    var newRecord = new Tdcooxseguimientoequiporesp
                    {
                        Cliente = seguimiento.Cliente,
                        Codigo = seguimiento.Codigo,
                        FechaAlta = seguimiento.FechaAlta,
                        FechaBaja = seguimiento.FechaBaja,
                        Usuario = seguimiento.Usuario,
                        FechaAudit = seguimiento.FechaAudit,
                        EnvCont = seguimiento.EnvCont
                    };

                    await db.Tdcooxseguimientoequiposresps.AddAsync(newRecord);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Método para obtener la consulta dinámica
        private string GetQueryForOption(string option)
        {
            return option switch
            {
                "clienteFirma" => @"
            select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
            from TMCOENV01 env
            inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
            inner join TMCOOXCLIENTES cli on cli.Cliente = seg.Cliente
            inner join TMCOCTGRAL GRAL on GRAL.Cliente = cli.Cliente
            inner join TMCOINPROD01 prod01 on prod01.Codigo = env.Codigo
            inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
            where seg.Codigo = env.Codigo 
                and seg.EnvCont > env.EnvCont 
                and env.EnvProp = 0 
                and GRAL.TipoCte = 'O' 
                and cli.CteFirma = @valor
                and cli.FechaBaja < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
            order by cli.Cliente;
        ",

                "clienteAgrupado" => @"
            select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
            from TMCOENV01 env
            inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
            inner join TMCOOXCLIENTES cli on cli.Cliente = seg.Cliente
            inner join TMCOCTGRAL GRAL on GRAL.Cliente = cli.Cliente
            inner join TMCOINPROD01 prod01 on prod01.Codigo = env.Codigo
            inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
            where seg.Codigo = env.Codigo 
                and seg.EnvCont > env.EnvCont 
                and env.EnvProp = 0 
                and GRAL.TipoCte = 'O' 
                and GRAL.SubTipoCte = @valor
                and cli.FechaBaja < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
            order by cli.Cliente;
        ",

                "paciente" => @"
            select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
            from TMCOENV01 env
            inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
            inner join TMCOOXCLIENTES cli on cli.Cliente = seg.Cliente
            inner join TMCOCTGRAL GRAL on GRAL.Cliente = cli.Cliente
            inner join TMCOINPROD01 prod01 on prod01.Codigo = env.Codigo
            inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
            where seg.Codigo = env.Codigo 
                and seg.EnvCont > env.EnvCont 
                and env.EnvProp = 0 
                and GRAL.TipoCte = 'O' 
                and cli.Cliente = @valor;
        ",

                "pacientes" => @"
            select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
            from TMCOENV01 env
            inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
            inner join TMCOOXCLIENTES cli on cli.Cliente = seg.Cliente
            inner join TMCOCTGRAL GRAL on GRAL.Cliente = cli.Cliente
            inner join TMCOINPROD01 prod01 on prod01.Codigo = env.Codigo
            inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
            where seg.Codigo = env.Codigo 
                and seg.EnvCont > env.EnvCont 
                and env.EnvProp = 0 
                and GRAL.TipoCte = 'O' 
                and cli.Cliente = @valor
                and cli.FechaBaja < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
            order by cli.Cliente;
        ",

                _ => throw new ArgumentException("Opción no válida"),
            };
        } 

        private string GetQueryForOptionRentasRecetas(string option)
        {
            return option switch
            {
                "clienteFirma" => @" select cli.cliente FROM TMCOOXCLIENTES cli INNER JOIN TMCOCTGRAL GRAL ON GRAL.Cliente = Cli.Cliente where cli.CteFirma  = @valor;",

                "clienteAgrupado" => @"select GRAL.cliente FROM TMCOCTGRAL GRAL WHERE GRAL.TipoCte = 'O' and gral.SubTipoCte = @valor;",

                "paciente" => @"select cli.cliente FROM TMCOOXCLIENTES cli where cli.cliente = @valor;",

                "pacientes" => @"select cli.cliente FROM TMCOOXCLIENTES cli where cli.cliente IN (SELECT value FROM  (@Pacientes);",

                _ => throw new ArgumentException("Opción no válida"),
            };
        }


        private string GetUpdateQuery()
        {
            return @"UPDATE TDCOOXSEGUIMIENTOEQUIPO SET EnvCont = @Dotacion WHERE Cliente = @Cliente AND Codigo = @Codigo";
        }

        private string GetUpdateQueryConFecha()
        {
            return @"UPDATE TDCOOXSEGUIMIENTOEQUIPO SET EnvCont = @Dotacion, FechaBaja = @Fecha WHERE Cliente = @Cliente AND Codigo = @Codigo";
        }

        public class SeguimientoRequest
        {
            public string Option { get; set; } // clienteFirma, clienteAgrupado, paciente, pacientes
            public string Value { get; set; } // clienteFirma, clienteAgrupado, paciente, pacientes
            public List<int> Pacientes { get; set; } // List of multiple pacientes to process 
            public int anio { get; set; }
            public int mes { get; set; }
        }
    }
}
