using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinembarquelotescantidad
    {
        public int Id { get; set; }
        public int? FolioEmbarque { get; set; }
        public int? CodigoProducto { get; set; }
        public int? Idlote { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
