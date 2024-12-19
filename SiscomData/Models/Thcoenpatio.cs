using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoenpatio
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? Envases { get; set; }
    }
}
