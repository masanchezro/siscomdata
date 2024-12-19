using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofaretencione
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
