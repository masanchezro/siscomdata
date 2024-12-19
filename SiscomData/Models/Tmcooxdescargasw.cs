using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxdescargasw
    {
        public string Hash { get; set; }
        public string Tipo { get; set; }
        public bool? Descargado { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
