using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocasolcontabilidadsaldotmp
    {
        public decimal? Saldo { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int? NoDocumento { get; set; }
    }
}
