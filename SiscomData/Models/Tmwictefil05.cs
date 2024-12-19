using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmwictefil05
    {
        public int Grupo { get; set; }
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
