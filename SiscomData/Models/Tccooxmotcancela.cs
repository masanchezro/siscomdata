using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxmotcancela
    {
        public int MotivoId { get; set; }
        public string DescCorta { get; set; }
        public string Descripcion { get; set; }
        public string Pantalla { get; set; }
        public bool? BloqueaPaciente { get; set; }
        public bool? Suspendido { get; set; }
        public bool? EsVisible { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
