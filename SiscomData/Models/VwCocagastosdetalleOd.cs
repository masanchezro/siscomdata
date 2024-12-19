using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocagastosdetalleOd
    {
        public string AfectaSuc { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string ServicioDescripcion { get; set; }
        public string Factura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
