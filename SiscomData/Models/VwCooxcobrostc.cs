using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcobrostc
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Codigo { get; set; }
        public short Sucursal { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public string NoTarjeta { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? DiasRenta { get; set; }
        public string Dot { get; set; }
        public string Auto { get; set; }
        public string CodigoAuto { get; set; }
        public int Factura { get; set; }
        public string Rfc { get; set; }
        public string TipoRenta { get; set; }
    }
}
