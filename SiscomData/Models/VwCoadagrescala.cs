using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoadagrescala
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? NoClienteInfra { get; set; }
        public decimal? CantidadFac { get; set; }
        public decimal? Acumulado { get; set; }
    }
}
