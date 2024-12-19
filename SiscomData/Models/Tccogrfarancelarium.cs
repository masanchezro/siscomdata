using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrfarancelarium
    {
        public string FraccionArancelaria { get; set; }
        public DateTime? FechaInicioVig { get; set; }
        public DateTime? FechaFinVig { get; set; }
        public string Criterio { get; set; }
        public string Um { get; set; }
        public string ImpuestoImp { get; set; }
        public string ImpuestoExp { get; set; }
    }
}
