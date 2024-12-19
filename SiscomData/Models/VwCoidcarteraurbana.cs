using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidcarteraurbana
    {
        public int? Sucursal { get; set; }
        public string Fecha { get; set; }
        public int Cliente { get; set; }
        public int FolioControl { get; set; }
        public int Folio { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal? Totalpesos { get; set; }
        public decimal? Total { get; set; }
    }
}
