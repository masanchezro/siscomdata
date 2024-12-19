using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinpedmerc
    {
        public short TipoPedido { get; set; }
        public int AlmacenCliente { get; set; }
        public int Proveedor { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Codigo { get; set; }
        public int Partida { get; set; }
        public decimal Costo { get; set; }
        public string Moneda { get; set; }
    }
}
