using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Saldosfactura
    {
        public int RecordId { get; set; }
        public int FolioFactura { get; set; }
        public int CodigoProducto { get; set; }
        public decimal? Salida { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public int? FolioPedido { get; set; }
    }
}
