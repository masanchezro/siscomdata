using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoctgralcbe
    {
        public int Cabecera { get; set; }
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string DiaCobro { get; set; }
        public string DiaRevision { get; set; }
        public string ZonaCobro { get; set; }
        public string Rfc { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string EmailEnvio { get; set; }
    }
}
