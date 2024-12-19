using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctcontrato
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Rfc { get; set; }
        public string Contrato { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool? Vigente { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
