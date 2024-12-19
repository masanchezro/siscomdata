using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoidsaplog
    {
        public int Id { get; set; }
        public DateTime Fechasap { get; set; }
        public string Tiposap { get; set; }
        public string Mensajeerror { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
