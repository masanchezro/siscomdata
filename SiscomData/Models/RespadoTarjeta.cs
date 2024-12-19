using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class RespadoTarjeta
    {
        public int MovimientoId { get; set; }
        public int Cliente { get; set; }
        public int Sucursal { get; set; }
        public int Servicio { get; set; }
        public double ImporteCobro { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public string NoTarjeta { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Dias { get; set; }
        public string ArchivoSalida { get; set; }
        public string ArchivoEntrada { get; set; }
        public string IdTransaccion { get; set; }
        public string NoAutorizacion { get; set; }
        public double? ImporteCargado { get; set; }
        public double? ImporteRechazado { get; set; }
        public int? Factura { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Dotacion { get; set; }
        public string CodigoAuto { get; set; }
    }
}
