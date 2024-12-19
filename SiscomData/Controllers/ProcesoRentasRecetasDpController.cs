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

        [HttpPost]
        [Route("ObtenerRentasRecetas")]
        public async Task<IActionResult> ObtenerRentasRecetas()
        {
            try
            {
                int mes = 10;
                int anio = 2024;

                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    // Get clients with "AS" type
                    var clients = db.Tccooxclientes
                        .Where(x => x.TipoParticular == "AS")
                        .Select(a => a.IdClietesOx)
                        .ToList();

                    var discrepancies = new List<object>();
                    var processedCodigos = new List<string>();

                    string auxProcesed = string.Empty;
                    foreach (int idClienteAseguradora in clients)
                    {
                        var result = await connection.QueryAsync<RentasRecetasResult>(queryPrincipal, new { Mes = mes, Anio = anio, ClienteId = idClienteAseguradora });

                        var filteredResult = result.Where(x => x.CoincideCodigo == "No coincide").ToList();
                        processedCodigos.Add($"Cliente Aseguradora: {idClienteAseguradora}");

                        if (filteredResult.Count > 0)
                        {
                            foreach (var clienteRenta in filteredResult)
                            {
                                if (auxProcesed == clienteRenta.Cliente_Renta)
                                {
                                    break;
                                }
                                processedCodigos.Add($"Cliente Renta: {clienteRenta.Cliente_Renta}");

                                var rentas = db.Tdcooxrentasctes
                                    .Where(x => x.Cliente.ToString() == clienteRenta.Cliente_Renta.ToString())
                                    .Select(x => x.Codigo)
                                    .ToList();

                                var recetas = db.Tmcooxrecetadps
                                    .Where(x => x.Cliente.ToString() == clienteRenta.Cliente_Renta && x.Mes == mes && x.Anio == anio && x.DpfechaInicio != null && x.DpfechaFin != null)
                                    .Select(x => Convert.ToInt32(x.TipoServicio))
                                    .ToList();

                                if (recetas.Count > 1)
                                {

                                }

                                var rentasString = string.Join(", ", rentas);
                                var recetasString = string.Join(", ", recetas);

                                processedCodigos.Add($"Rentas: {rentasString}");
                                processedCodigos.Add($"Recetas: {recetasString}");

                                if (rentas.Count == 1 && recetas.Count == 1)
                                {
                                    var renta = rentas.First();
                                    var receta = recetas.First();

                                    if (renta != receta)
                                    {
                                        discrepancies.Add(new
                                        {
                                            Cliente = clienteRenta.Cliente_Renta,
                                            Rentas = renta,
                                            Recetas = receta,
                                            Note = "1 vs 1"
                                        });

                                        string updateSql = $@" UPDATE Tdcooxrentascte SET Codigo = {receta}, FechaAudit = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', Observaciones = 'Actualizado 1vs1'" +
                                        @"WHERE Cliente = '{clienteRenta.Cliente_Renta}' AND Codigo = {renta};";

                                        // Write the query to file immediately
                                        await System.IO.File.AppendAllTextAsync(OutputFilePath, updateSql + Environment.NewLine);
                                    }
                                }
                                else
                                {
                                    var rentasOnly = rentas.Except(recetas).ToList();
                                    var recetasOnly = recetas.Except(rentas).ToList();

                                    if (rentasOnly.Any() || recetasOnly.Any())
                                    {
                                        discrepancies.Add(new
                                        {
                                            Cliente = clienteRenta.Cliente_Renta,
                                            RentasOnly = rentasOnly,
                                            RecetasOnly = recetasOnly
                                        });

                                        foreach (var codigo in recetasOnly)
                                        {
                                            if (codigo != 777255)
                                            {
                                                DateTime today = DateTime.Now;
                                                DateTime lastMonth = today.AddMonths(-1);
                                                int day = 30;

                                                DateTime fechaUltRentaDate = new DateTime(lastMonth.Year, lastMonth.Month, Math.Min(day, DateTime.DaysInMonth(lastMonth.Year, lastMonth.Month)));

                                                string fechaUltRenta = fechaUltRentaDate.ToString("yyyy-MM-dd HH:mm:ss");

                                                var recetaObj = db.Tmcooxrecetadps.Where(x => x.Cliente.ToString() == clienteRenta.Cliente_Renta
                                                    && x.Mes == mes && x.Anio == anio && x.TipoServicio == codigo.ToString()).ToList();

                                                var rentaObj = db.Tmcooxrecetadps.Where(x => x.Cliente.ToString() == clienteRenta.Cliente_Renta
                                                    && x.Mes == mes && x.Anio == anio && x.TipoServicio == codigo.ToString()
                                                    && x.TipoServicio != "777255").ToList();


                                                var dotacionObj = db.Tmcoenv01s.Where(x => x.Cliente == Convert.ToInt32(clienteRenta.Cliente_Renta) && x.EnvCont > 0).ToList();

                                                foreach (var itemDotacion in dotacionObj)
                                                {

                                                    var prodObj = db.Tmcooxproductos.Where(x => x.Codigo == itemDotacion.Codigo).FirstOrDefault();

                                                    string sql = $@"INSERT INTO Tdcooxrentascte(Sucursal, Cliente, Codigo, FechaUltRenta, CodigoEnvases, DotacionFinal, FolioFactura, FolioAltaRenta, ImprimirFactura, Usuario, FechaAudit, Observaciones, Pantalla)" +
                                                                 $@"VALUES('{rentaObj.FirstOrDefault()?.Sucursal}', '{clienteRenta.Cliente_Renta}', {prodObj.CodigoRenta}, '{fechaUltRenta}', {prodObj.Codigo}, {dotacionObj.FirstOrDefault().EnvCont}, {recetaObj.FirstOrDefault()?.FolioFactura ?? 0}, " +
                                                                 $@"0, 0, 'System', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}', 'Auto: Actualiza Renta', 'CteFirma RR/RC');";

                                                    // Write the query to file immediatel
                                                    await System.IO.File.AppendAllTextAsync(OutputFilePath, sql + Environment.NewLine);
                                                }
                                                auxProcesed = clienteRenta.Cliente_Renta;

                                            }
                                        }
                                    }
                                }

                                // Write processed codigos log immediately
                                await System.IO.File.AppendAllLinesAsync(CodigoLogFilePath, processedCodigos);
                                processedCodigos.Clear();
                            }
                        }
                    }

                    return Ok(new
                    {
                        Discrepancies = discrepancies,
                        FilePath = OutputFilePath,
                        CodigoLogPath = CodigoLogFilePath
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = ex.Message
                });
            }
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

        [HttpPost]
        [Route("ActualizaSeguimientoDotacion")]
        public async Task<IActionResult> ActualizaSeguimientoDotacion([FromBody] SeguimientoRequest request)
        {
            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    var logEntries = new List<string>();
                    logEntries.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Iniciando Actualización: Opción - {request.Option}, Valor - {request.Value}");
                     
                    string selectedQuery = GetQueryForOption(request.Option);
                     
                    var resultQuery = await connection.QueryAsync<SeguimientoDotacionDto>(selectedQuery, new { valor = request.Value });

                    foreach (SeguimientoDotacionDto item in resultQuery)
                    {
                        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        logEntries.Add($"{timestamp} - Cliente: {item.Cliente}, Codigo: {item.Codigo}, EnvContEnv: {item.EnvContEnv}, EnvContSeg: {item.EnvContSeg}");

                        if (item.EnvContEnv != item.EnvContSeg)
                        {
                            var dotacionResp = db.Tdcooxseguimientoequipos.FirstOrDefault(x => x.Cliente == item.Cliente && x.Codigo == int.Parse(item.Codigo));
                            await AddToSeguimientoEquipoRespAsync(dotacionResp);

                            await connection.ExecuteAsync(GetUpdateQuery(), new
                            {
                                Dotacion = item.EnvContEnv,
                                Cliente = item.Cliente,
                                Codigo = item.Codigo
                            });

                            logEntries.Add($"{timestamp} - Actualizado - Cliente: {item.Cliente}, Codigo: {item.Codigo}, Nuevo EnvCont: {item.EnvContEnv}");

                        }

                    }

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
                "clienteFirma" => @"select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
                                --distinct(env.Cliente)
                                from TMCOENV01 env
                                inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
                                inner join TMCOOXCLIENTES cli on cli.Cliente = seg.cliente
                                INNER JOIN TMCOCTGRAL GRAL ON GRAL.Cliente = Cli.Cliente
                                inner join TMCOINPROD01 prod01 on prod01.codigo = env.codigo
                                inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
                                where seg.Codigo = env.Codigo and seg.EnvCont > env.EnvCont and env.EnvProp = 0 
                                and GRAL.TipoCte = 'O' and cli.CteFirma = @valor;",

                "clienteAgrupado" => @"select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
                                --distinct(env.Cliente)
                                from TMCOENV01 env
                                inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
                                inner join TMCOOXCLIENTES cli on cli.Cliente = seg.cliente
                                INNER JOIN TMCOCTGRAL GRAL ON GRAL.Cliente = Cli.Cliente
                                inner join TMCOINPROD01 prod01 on prod01.codigo = env.codigo
                                inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
                                where seg.Codigo = env.Codigo and seg.EnvCont > env.EnvCont and env.EnvProp = 0 
                                and GRAL.TipoCte = 'O' and gral.SubTipoCte = @valor;",

                "paciente" => @"select env.Cliente, env.Codigo, env.EnvCont as EnvContEnv, seg.EnvCont as EnvContSeg
                                --distinct(env.Cliente)
                                from TMCOENV01 env
                                inner join TDCOOXSEGUIMIENTOEQUIPO seg on seg.Cliente = env.Cliente
                                inner join TMCOOXCLIENTES cli on cli.Cliente = seg.cliente
                                INNER JOIN TMCOCTGRAL GRAL ON GRAL.Cliente = Cli.Cliente
                                inner join TMCOINPROD01 prod01 on prod01.codigo = env.codigo
                                inner join TMCOOXPRODUCTOS prod on prod.Codigo = prod01.Codigo
                                where seg.Codigo = env.Codigo and seg.EnvCont > env.EnvCont and env.EnvProp = 0 
                                and GRAL.TipoCte = 'O' and cli.cliente = @valor;",

                _ => throw new ArgumentException("Opción no válida"),
            };
        }

        private string GetUpdateQuery()
        {
            return @"UPDATE TDCOOXSEGUIMIENTOEQUIPO SET EnvCont = @Dotacion WHERE Cliente = @Cliente AND Codigo = @Codigo";
        }

        public class SeguimientoRequest
        {
            public string Option { get; set; } // clienteFirma, clienteAgrupado, paciente
            public string Value { get; set; } // Value to filter (e.g., ClienteFirma)
        }

        string seguimientoEquiposUpdateQuery = @"Update TDCOOXSEGUIMIENTOEQUIPO set EnvCont = @Dotacion where cliente = @Cliente and codigo = @Codigo";

        string seguimientoEquiposQuery = @"SELECT * FROM TDCOOXSEGUIMIENTOEQUIPO where cliente = @Cliente and codigo = @Codigo";

        string query = @"SELECT 
                        env.Cliente, env.Codigo, env.EnvCont AS EnvContEnv, seg.EnvCont AS EnvContSeg
                    FROM TMCOENV01 env
                    INNER JOIN TDCOOXSEGUIMIENTOEQUIPO seg ON seg.Cliente = env.Cliente
                    INNER JOIN TMCOOXCLIENTES cli ON cli.Cliente = seg.Cliente
                    INNER JOIN TMCOCTGRAL GRAL ON GRAL.Cliente = cli.Cliente
                    INNER JOIN TMCOINPROD01 prod01 ON prod01.Codigo = env.Codigo
                    INNER JOIN TMCOOXPRODUCTOS prod ON prod.Codigo = prod01.Codigo
                    WHERE seg.Codigo = env.Codigo 
                        AND seg.EnvCont > env.EnvCont 
                        AND env.EnvProp = 0 
                        AND GRAL.TipoCte = 'O' 
                        AND cli.CteFirma IN (@ClienteFirma)";
    }
}
