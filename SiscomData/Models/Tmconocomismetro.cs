using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmconocomismetro
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public int Nomina { get; set; }
        public int? Mercancias { get; set; }
        public int? Gases { get; set; }
        public decimal? Ventas { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
