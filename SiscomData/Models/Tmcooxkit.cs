using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxkit
    {
        public int IdKit { get; set; }
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public string TipoKit { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
