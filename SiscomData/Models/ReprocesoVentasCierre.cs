using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ReprocesoVentasCierre
    {
        public short? Suc { get; set; }
        public int? Cliente { get; set; }
        public int? Codigo { get; set; }
        public double? UniEne { get; set; }
        public double? ValEne { get; set; }
        public double? CarEne { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaUltCon { get; set; }
    }
}
