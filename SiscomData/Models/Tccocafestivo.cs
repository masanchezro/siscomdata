using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocafestivo
    {
        public DateTime FechaFestiva { get; set; }
        public DateTime FechaReemplazo { get; set; }
        public string Usuario { get; set; }
        public string Proceso { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
