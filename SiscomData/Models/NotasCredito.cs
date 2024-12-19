using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class NotasCredito
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public int TipoServicio { get; set; }
        public int FolioControl { get; set; }
        public DateTime? FechaFe { get; set; }
        public decimal? ImpFactura { get; set; }
    }
}
