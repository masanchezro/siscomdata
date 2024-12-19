using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofadetalleimpuesto
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public decimal Tasa { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? IvaRet { get; set; }
        public string TipoImpuesto { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? SubtotalRetenciones { get; set; }
        public decimal? TasaRetenciones { get; set; }
    }
}
