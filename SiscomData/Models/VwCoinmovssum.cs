using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinmovssum
    {
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public decimal? ImporteOrigen { get; set; }
        public decimal? Ivaorigen { get; set; }
        public decimal? TotalOrigen { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public string Moneda { get; set; }
    }
}
