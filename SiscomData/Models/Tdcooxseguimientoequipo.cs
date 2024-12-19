using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxseguimientoequipo
    {
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int EnvCont { get; set; }
    }
}
