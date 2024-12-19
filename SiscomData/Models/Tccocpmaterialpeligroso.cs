using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocpmaterialpeligroso
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Clase { get; set; }
        public string Peligro { get; set; }
        public string Grupo { get; set; }
        public string DispEsp { get; set; }
        public string CantidadLim { get; set; }
        public string CisternasConte { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
