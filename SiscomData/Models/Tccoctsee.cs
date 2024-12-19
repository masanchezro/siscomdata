using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctsee
    {
        public string CveSee { get; set; }
        public decimal? Escala1 { get; set; }
        public decimal? Escala2 { get; set; }
        public decimal? Escala3 { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
