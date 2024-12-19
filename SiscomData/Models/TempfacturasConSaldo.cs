using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TempfacturasConSaldo
    {
        public short? Ccsucursal { get; set; }
        public int? Cliente { get; set; }
        public int? NoDocumento { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteDlls { get; set; }
        public decimal? TipoCambio { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? SucursalOrigen { get; set; }
    }
}
