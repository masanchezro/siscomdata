using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmoxiexentosaut
    {
        public DateTime FechaMov { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoExento { get; set; }
        public string Solicito { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
    }
}
