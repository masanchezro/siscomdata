using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofapromacum
    {
        public string Codigo { get; set; }
        public bool? Transmitir { get; set; }
        public int? Sucursal { get; set; }
        public int? FacturaUso { get; set; }
        public int Cliente { get; set; }
    }
}
