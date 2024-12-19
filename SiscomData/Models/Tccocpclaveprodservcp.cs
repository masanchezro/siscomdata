using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocpclaveprodservcp
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Palabras { get; set; }
        public string MaterialPeligroso { get; set; }
        public DateTime? FehcaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
