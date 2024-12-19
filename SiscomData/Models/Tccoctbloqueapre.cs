using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctbloqueapre
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string TipoBloqueo { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
