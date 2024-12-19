using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxpereqp01
    {
        public int IdPermiso { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? CantTope { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
