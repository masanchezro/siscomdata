using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SiscomData.DAO;
using SiscomData.DTOS;
using SiscomData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiscomData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfraController : ControllerBase
    {
        private readonly BD_SISCOMV2_301Context db;
        int idPedido = 0;
        bool existeHistorico;
        int sucursalActiva = 301;
        DateTime fechaRuteo = new DateTime();
        public InfraController(BD_SISCOMV2_301Context context)
        {
            db = context;
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

                        var historico = await db.Thcooxrecepcionseries.Where(f => f.Pedido == int.Parse(Serie.servicio_Id)).FirstOrDefaultAsync();
                        if (historico == null)
                        {
                            historico = new Thcooxrecepcionseries();
                            historico.Pedido = int.Parse(Serie.servicio_Id);
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


                        if (Serie.prioridad == "N")
                        {
                            fechaRuteo = fechaRuteoSuc;
                        }
                        else if (Serie.prioridad == "U") //Identificar la fecha de urgencia
                        {
                            fechaRuteo = fechaRuteoOxi;
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

                                //_context.Tmcooxservicios.Actualizar(pedido); 

                                //if (_context.tdeq.AlgunElemento(f => f.Cliente == Serie.Cliente && f.Codigo == Serie.Codigo && f.NoSerie == Serie.Serie))//En caso de que exista la serie en TDCOINCTEEQUIPO no hacer nada (Caso de uso FOR-IT-02, Pag.8, Reglas de negocio No. 6)
                                //{
                                //    historico.FechaRuteo = fechaRuteo;
                                //    historico.Estatus = "P";
                                //    historico.Observaciones = $"La serie ({Serie.Serie}) ya existe en Cliente-Equipo, no se procesará; Cliente:{Serie.Cliente}, Pedido:{Serie.servicio_Id}, Codigo:{Serie.Codigo}";

                                //}

                                foreach (var serie in ListadoSeriesOxidom)
                                {

                                    var producto = await db.Tmcooxproductos.Where(f => f.Codigo == Serie.codigo).FirstOrDefaultAsync();
                                    if (producto != null && producto.RequiereFoto.Trim().ToUpper() == "S")
                                    {
                                        //var salidaSerie = db.RegistroSalidaSeries.Buscar(f => f.Sucursal == db.SucursalActiva && f.Cliente == Serie.Cliente).FirstOrDefault();
                                        var salidaSerie = await db.Tdcooxseriessyes.Where(f => f.Sucursal == sucursalActiva && f.Serie.Trim() == Serie.serie.Trim()).FirstOrDefaultAsync();
                                        if (salidaSerie != null)
                                        {
                                            //salidaSerie.Fecha = fechaRuteo; //Usar fecha ruteo
                                            //salidaSerie.FechaAudit = DateTime.Now;
                                            //salidaSerie.Serie = Serie.serie;
                                            //salidaSerie.Codigo = Serie.codigo;
                                            //salidaSerie.Cliente = Serie.cliente;
                                            //db.Entry(salidaSerie).State = EntityState.Modified; 
                                        }

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
                                            //Tmcooxcontrato NuevoContrato = new Tmcooxcontrato();
                                            //NuevoContrato.IdContrato = int.Parse(miscelaneo.Campo1);
                                            //NuevoContrato.Cliente = Serie.cliente;

                                            //miscelaneo.Campo1 = contrato.IdContrato++.ToString();

                                            //db.Tccogrmiscs.Actualizar(miscelaneo);
                                            //db.Tmcooxcontratos.Agregar(NuevoContrato);
                                        }
                                    }

                                    int.TryParse(Serie.servicio_Id, out idPedido);
                                    var MovimientoEnvases = await db.Tdcoenvmovs.Where(f => f.Sucursal == Serie.sucursal
                                   && f.Cliente == Serie.cliente && f.TipoMovimiento.Trim().ToUpper() == "I07" && f.FolioDeposito == idPedido).ToListAsync();

                                    if (MovimientoEnvases != null && MovimientoEnvases.FirstOrDefault().EstatusEntrega != false)
                                    {
                                        MovimientoEnvases.ForEach(i =>
                                        {
                                            i.EstatusEntrega = false;
                                            db.Entry(i).State = EntityState.Modified;

                                        });

                                        //MovimientoEnvases.EstatusEntrega = false;
                                        //db.MovimientosDeEnvases.Actualizar(MovimientoEnvases);
                                    }

                                    await db.SaveChangesAsync();

                                }
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

                        if (pedido != null)  //Si el pedido existe de acuerdo a las condiciones previas.
                        {
                            if (pedido.Cancelado == false && pedido.Ruteado == true)
                            {

                                pedido.EstatusServicio = "CO";
                                pedido.FechaInicioServ = Serie.fechaRecepcion;
                                pedido.FechaTerminoServ = Serie.fechaRecepcion;
                            }
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
