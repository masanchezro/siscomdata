using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctpagoautomatico
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public bool? Vigente { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Usuario { get; set; }
    }
}
