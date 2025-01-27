using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SiscomData.DAO;
using SiscomData.DTOS;
using SiscomData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SiscomData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfraController : ControllerBase
    {


        private readonly BD_SISCOMV2_301Context db;
        private readonly int sucursalActiva;

        int idPedido = 0;
        bool existeHistorico;

        DateTime fechaRuteo = new DateTime();
        public InfraController(BD_SISCOMV2_301Context context, IConfiguration configuration)
        {
            db = context;

            // Retrieve sucursalActiva from appSettings.json
            sucursalActiva = configuration.GetValue<int>("SucursalActiva");
        }


        [HttpPost]
        [Route("ProcesarIdentificadores1Nuevo")]

        public async Task<IActionResult> ProcesarIdentificadores1Nuevo([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    // Open the shared connection
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    //Validando si el servicio esta activo para recepcion de series 
                    //var ValidaServicio = db.Tmcooxwservices.Where(f => f.Servicio == "SADD").FirstOrDefault();

                    //Se valida el servicio para que sea SADD, de lo contrario se sale de la aplicación
                    //if (ValidaServicio == null || (ValidaServicio != null && ValidaServicio.EstatusSev.Trim() != "1"))
                    //{
                    //    return  ;
                    //}
                    DateTime fechaRuteoSuc = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva);
                    DateTime fechaRuteoOxi = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva, true);


                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        if (Serie.prioridad == "N")
                        {
                            fechaRuteo = fechaRuteoSuc;
                        }
                        else if (Serie.prioridad == "U") //Identificar la fecha de urgencia
                        {
                            fechaRuteo = fechaRuteoOxi;
                        }


                        if (db.Tmcooxservicios.Any(f => f.Pedido == int.Parse(Serie.servicio_Id)
                                                                 && f.Cliente == Serie.cliente
                                                                 && f.FechaRuteo.Date == fechaRuteo.Date
                                                                 && f.EstatusServicio.Trim().ToUpper() == "CO"))
                        {
                             break;
                        }
                         
                         var historico = db.Thcooxrecepcionseries.Where(f => f.Pedido == int.Parse(Serie.servicio_Id)
                                             && f.FechaRuteo.Value.Date == fechaRuteo.Date
                                             && f.Cliente == Serie.cliente).FirstOrDefault(); //Obtener el registro historico para no duplicar entradas en caso de existir
                        if (historico == null)
                        {
                            historico = new Thcooxrecepcionseries();
                            historico.Pedido = int.Parse(Serie.servicio_Id);
                            historico.FechaRuteo = fechaRuteo;
                            historico.Cliente = Serie.cliente;
                            historico.DetalleSerie = JsonConvert.SerializeObject(ListadoSeriesOxidom);
                            historico.FechaRecepcion = Serie.fechaRecepcion;
                            historico.Chofer = Serie.chofer;
                            historico.Origen = "SERIES";
                            historico.Estatus = "P";
                            existeHistorico = false;
                        }
                        else
                        {
                            existeHistorico = true;
                        }

                        var pedido = await db.Tmcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).FirstOrDefaultAsync();
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();

                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;

                                db.Tmcooxservicios.Update(pedido);

                                if (db.Tdcoincteequipos.Any(f => f.Cliente == Serie.cliente && f.Codigo == Serie.codigo && f.NoSerie == Serie.serie))//En caso de que exista la serie en TDCOINCTEEQUIPO no hacer nada (Caso de uso FOR-IT-02, Pag.8, Reglas de negocio No. 6)
                                {
                                    historico.FechaRuteo = fechaRuteo;
                                    historico.Estatus = "P";
                                    historico.Observaciones = $"La serie ({Serie.serie}) ya existe en Cliente-Equipo, no se procesará; Cliente:{Serie.cliente}, Pedido:{Serie.servicio_Id}, Codigo:{Serie.codigo}";

                                }

                                var producto = await db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefaultAsync();
                                if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                                {
                                    //var salidaSerie = db.RegistroSalidaSeries.Buscar(f => f.Sucursal == db.SucursalActiva && f.Cliente == Serie.Cliente).FirstOrDefault();
                                    var salidaSerie = await db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefaultAsync();
                                    if (salidaSerie != null)
                                    {
                                        db.Entry(salidaSerie).Reload();
                                        salidaSerie.Fecha = salidaSerie.Fecha; //Usar fecha ruteo
                                        salidaSerie.FechaAudit = DateTime.Now;
                                        salidaSerie.Serie = Serie.serie;
                                        salidaSerie.Codigo = Serie.codigo;
                                        salidaSerie.Cliente = Serie.cliente;
                                        salidaSerie.Usuario = "CentralRuteo";
                                        db.Entry(salidaSerie).State = EntityState.Modified;
                                    }

                                    db.Tdcoincteequipos.Add(new Tdcoincteequipo
                                    {
                                        Cliente = Serie.cliente,
                                        Cantidad = 1,
                                        Codigo = Serie.codigo,
                                        Modelo = Serie.modelo,
                                        //Id_ClienteEquipo = Serie.Cliente,
                                        NoActivoFijo = "",
                                        NoSerie = Serie.serie.ToString(),   
                                        Sucursal = short.Parse(sucursalActiva.ToString()),
                                        TipoMovimiento = "",
                                        Usuario = "CentralRuteo",
                                        FechaUltMov = DateTime.Now,
                                        FechaAlta = DateTime.Now,
                                        FechaRevision = DateTime.Now
                                    });
                                    //Solo sí se afecta un resgistro de serie
                                    cliente.Sector = 1.ToString();
                                    db.Entry(cliente).State = EntityState.Modified;
                                }

                                var contrato = await db.Tmcooxcontratos.Where(f => f.Cliente == Serie.cliente).OrderByDescending(f => f.IdContrato).FirstOrDefaultAsync();
                                if (contrato is null)
                                {
                                    var miscelaneo = await db.Tccogrmiscs.Where(f => f.Clave == "DATOSOXI").FirstOrDefaultAsync();
                                    int noContrato;
                                    if (int.TryParse(miscelaneo.Campo1, out noContrato))
                                    {
                                        noContrato = int.Parse(miscelaneo.Campo1) + 1;
                                        miscelaneo.Campo1 = noContrato.ToString();

                                        Tmcooxcontrato NuevoContrato = new Tmcooxcontrato();
                                        NuevoContrato.IdContrato = noContrato;
                                        NuevoContrato.Cliente = Serie.cliente;
                                        NuevoContrato.FechaUtlSincronizacion = DateTime.Now;
                                        NuevoContrato.FechaAudit = DateTime.Now;
                                        NuevoContrato.Tecnico = historico.Chofer.ToString();
                                        NuevoContrato.MontoRenta = 0;
                                        NuevoContrato.Deposito = 0;
                                        NuevoContrato.Usuario = "CentralRuteo";

                                        db.Tccogrmiscs.Update(miscelaneo);
                                        db.Tmcooxcontratos.Add(NuevoContrato);
                                    }
                                }

                                int.TryParse(Serie.servicio_Id, out idPedido);
                                var MovimientoEnvases = await db.Tdcoenvmovs.Where(f => f.Sucursal == Serie.sucursal
                                                                                                    && f.Cliente == Serie.cliente
                                                                                                    && f.TipoMovimiento.Trim().ToUpper() == "I07"
                                                                                                    && f.FolioDeposito == idPedido).ToListAsync();

                                if (MovimientoEnvases != null && MovimientoEnvases.Count > 0)
                                {
                                    if (MovimientoEnvases.FirstOrDefault().EstatusEntrega != false)
                                        MovimientoEnvases.ForEach(i =>
                                        {
                                            i.EstatusEntrega = false;
                                            db.Entry(i).State = EntityState.Modified;

                                        });
                                    //MovimientoEnvases.EstatusEntrega = false;
                                    //db.MovimientosDeEnvases.Actualizar(MovimientoEnvases);
                                } 
                            }
                        }
                        else
                        {
                            historico.FechaRuteo = fechaRuteo;
                            historico.Estatus = "E";
                            historico.Observaciones = $"El pedido {Serie.servicio_Id}) está cancelado o no se ha rueteado: Cancelado:{pedido.Cancelado} Ruteado:{pedido.Ruteado}, no se procesará";
                        }


                        if (existeHistorico)
                            db.Thcooxrecepcionseries.Update(historico);
                        else
                            db.Thcooxrecepcionseries.Add(historico);

                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }

        [HttpPost]
        [Route("ProcesarIdentificadores2Recarga")]
        public async Task<IActionResult> ProcesarIdentificadores2Recarga([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    DateTime fechaRuteoSuc = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva);
                    DateTime fechaRuteoOxi = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva, true);

                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        var pedido = await db.Tmcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).FirstOrDefaultAsync();
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();
                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;

                                if (Serie.prioridad == "N")
                                {
                                    fechaRuteo = fechaRuteoSuc;
                                }
                                else if (Serie.prioridad == "U") //Identificar la fecha de urgencia
                                {
                                    fechaRuteo = fechaRuteoOxi;
                                }

                                var producto = db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefault();

                                if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                                {
                                    var salidaSerie = db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefault();
                                    if (salidaSerie != null)
                                    {
                                        salidaSerie.Fecha = fechaRuteo; //Usar fecha ruteo
                                        salidaSerie.FechaAudit = DateTime.Now;
                                        salidaSerie.Serie = Serie.serie;
                                        salidaSerie.Codigo = Serie.codigo;
                                        salidaSerie.Cliente = Serie.cliente;
                                        db.Entry(salidaSerie).State = EntityState.Modified;
                                    }
                                    //Solo si se afecta un resgistro de serie
                                    cliente.Sector = 1.ToString();
                                    db.Entry(cliente).State = EntityState.Modified;
                                }

                                await db.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }

        [HttpPost]
        [Route("ProcesarIdentificadores3Revision")]
        public async Task<IActionResult> ProcesarIdentificadores3Revision([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    DateTime fechaRuteoSuc = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva);
                    DateTime fechaRuteoOxi = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva, true);

                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();
                        var pedido = await db.Tmcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).FirstOrDefaultAsync();
                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;
                                if (Serie.prioridad == "N")
                                {
                                    fechaRuteo = fechaRuteoSuc;
                                }
                                else if (Serie.prioridad == "U") //Identificar la fecha de urgencia
                                {
                                    fechaRuteo = fechaRuteoOxi;
                                }

                                var producto = db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefault();

                                if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                                {
                                    var salidaSerie = db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefault();
                                    if (salidaSerie != null)
                                    {
                                        salidaSerie.Fecha = fechaRuteo;
                                        salidaSerie.FechaAudit = DateTime.Now;
                                        salidaSerie.Serie = Serie.serie;
                                        salidaSerie.Codigo = Serie.codigo;
                                        db.Entry(salidaSerie).State = EntityState.Modified;
                                    }

                                    cliente.Sector = 1.ToString();
                                    db.Entry(cliente).State = EntityState.Modified;
                                }

                                await db.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }

        [HttpPost]
        [Route("ProcesarIdentificadores5Aumento")]
        public async Task<IActionResult> ProcesarIdentificadores5Aumento([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    // Open the shared connection
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        var pedido = await db.Tmcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).FirstOrDefaultAsync();
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();

                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;
                            }
                             
                            var producto = await db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefaultAsync();
                            if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                            {
                                //var salidaSerie = db.RegistroSalidaSeries.Buscar(f => f.Sucursal == db.SucursalActiva && f.Cliente == Serie.Cliente).FirstOrDefault();
                                var salidaSerie = await db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefaultAsync();
                                if (salidaSerie != null)
                                {
                                    db.Entry(salidaSerie).Reload();
                                    salidaSerie.Fecha = salidaSerie.Fecha; //Usar fecha ruteo
                                    salidaSerie.FechaAudit = DateTime.Now;
                                    salidaSerie.Serie = Serie.serie;
                                    salidaSerie.Codigo = Serie.codigo;
                                    salidaSerie.Cliente = Serie.cliente;
                                    salidaSerie.Usuario = "CentralRuteo";
                                    db.Entry(salidaSerie).State = EntityState.Modified;
                                }

                                db.Tdcoincteequipos.Add(new Tdcoincteequipo
                                {
                                    Cliente = Serie.cliente,
                                    Cantidad = 1,
                                    Codigo = Serie.codigo,
                                    Modelo = Serie.modelo,
                                    //Id_ClienteEquipo = Serie.Cliente,
                                    NoActivoFijo = "",
                                    NoSerie = Serie.serie.ToString(),
                                    Sucursal = short.Parse(sucursalActiva.ToString()),
                                    TipoMovimiento = "",
                                    Usuario = "CentralRuteo",
                                    FechaUltMov = DateTime.Now,
                                    FechaAlta = DateTime.Now,
                                    FechaRevision = DateTime.Now
                                });
                                //Solo sí se afecta un resgistro de serie
                                cliente.Sector = 1.ToString();
                                db.Entry(cliente).State = EntityState.Modified;
                            }

                            int.TryParse(Serie.servicio_Id, out idPedido);
                            var MovEnvases = db.Tdcoenvmovs.Where(f => f.Sucursal == Serie.sucursal
                                                                              && f.Cliente == Serie.cliente
                                                                              && f.TipoMovimiento.Trim().ToUpper() == "I07"
                                                                              && f.FolioDeposito == idPedido).ToList();

                            if (MovEnvases != null && MovEnvases.FirstOrDefault().EstatusEntrega != false)
                            {
                                MovEnvases.ForEach(i =>
                                {
                                    i.EstatusEntrega = false;
                                    db.Entry(i).State = EntityState.Modified;
                                });
                            }



                        }

                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }

        [HttpPost]
        [Route("ProcesarIdentificadores7CancelacionPedido")]
        public async Task<IActionResult> ProcesarIdentificadores7CancelacionPedido([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    DateTime fechaRuteoSuc = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva);
                    DateTime fechaRuteoOxi = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva, true);

                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        var pedido = await db.Tmcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).FirstOrDefaultAsync();
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();
                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;
                                if (Serie.prioridad == "N")
                                {
                                    fechaRuteo = fechaRuteoSuc;
                                }
                                else if (Serie.prioridad == "U") //Identificar la fecha de urgencia
                                {
                                    fechaRuteo = fechaRuteoOxi;
                                }

                                var producto = db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefault();
                                var pedidoDetalle = await db.Tdcooxservicios.Where(f => f.Pedido.ToString() == Serie.servicio_Id && f.Cliente == Serie.cliente && f.Sucursal == Serie.sucursal).ToListAsync();

                                if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                                {
                                    var salidaSerie = db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefault();
                                    if (salidaSerie != null)
                                    {
                                        salidaSerie.Fecha = fechaRuteo; //Usar fecha ruteo
                                        salidaSerie.FechaAudit = DateTime.Now;
                                        salidaSerie.Serie = Serie.serie;
                                        salidaSerie.Codigo = Serie.codigo;
                                        db.Entry(salidaSerie).State = EntityState.Modified;
                                    }
                                    //Solo si se afecta un resgistro de serie
                                    cliente.Sector = 1.ToString();
                                    db.Entry(cliente).State = EntityState.Modified;
                                }

                                var seguimientoEquipo = db.Tdcooxseguimientoequipos.Where(f => f.Cliente == Serie.cliente && f.Codigo == int.Parse(Serie.modeloSISCOM)).FirstOrDefault(); //Se utiliza ModeloSICOM como indica el caso de uso
                                if (seguimientoEquipo != null)
                                {
                                    var pedidoDet = pedidoDetalle.FirstOrDefault(f => f.Codigo == int.Parse(Serie.modeloSISCOM) && f.Cliente == Serie.cliente);
                                    seguimientoEquipo.FechaBaja = Serie.fechaRecepcion; //Checar si es la fecha recepcion (Serie.FechaRecepcion) o la fecha del día (DateTime.Now)
                                    seguimientoEquipo.Usuario = "SADD";
                                    seguimientoEquipo.EnvCont = seguimientoEquipo.EnvCont - 0;  //- Serie.  Caso de uso dice: "Envcont con la resta de la cantidad recibida", no tengo manera de saber la cantidad recibida.
                                    db.Entry(seguimientoEquipo).State = EntityState.Modified;
                                }
                            }

                            await db.SaveChangesAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }

        [HttpPost]
        [Route("ProcesarIdentificadores9ServicioDeCobro")]
        public async Task<IActionResult> ProcesarIdentificadores9ServicioDeCobro([FromBody] InformacionDTO data)
        {
            List<IdentificadoresDetalleDTO> ListadoSeriesOxidom = JsonConvert.DeserializeObject<List<IdentificadoresDetalleDTO>>(data.Informacion);

            try
            {
                using (var connection = db.Database.GetDbConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    DateTime fechaRuteoSuc = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva);
                    DateTime fechaRuteoOxi = await DabaseUtils.GetMaxFechaRuteo(db, connection, sucursalActiva, true);

                    foreach (var Serie in ListadoSeriesOxidom)
                    {
                        var cliente = await db.Tmcooxclientes.Where(f => f.Cliente == Serie.cliente).FirstOrDefaultAsync();

                        if (Serie.prioridad == "N")
                        {
                            fechaRuteo = fechaRuteoSuc;
                        }
                        else if (Serie.prioridad == "U")
                        {
                            fechaRuteo = fechaRuteoOxi;
                        }

                        var producto = db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefault();

                        if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                        {
                            var salidaSerie = db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefault();
                            if (salidaSerie != null)
                            {
                                salidaSerie.Fecha = fechaRuteo; //Usar fecha ruteo
                                salidaSerie.FechaAudit = DateTime.Now;
                                salidaSerie.Serie = Serie.serie;
                                salidaSerie.Codigo = Serie.codigo;
                                db.Entry(salidaSerie).State = EntityState.Modified;
                            }

                            cliente.Sector = 1.ToString();
                            db.Entry(cliente).State = EntityState.Modified;
                        }

                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());

            }
            return Ok("Correcto");
        }
    }
}
