using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinpedmerc
    {
        public string TipoPedido { get; set; }
        public string TipoPedidoSap { get; set; }
        public int AlmacenCliente { get; set; }
        public int Proveedor { get; set; }
        public int Pedido { get; set; }
        public string DoctoSap { get; set; }
        public int Codigo { get; set; }
        public int Partida { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal CantSolicitada { get; set; }
        public decimal CantSurtida { get; set; }
        public decimal? TotalSolicitada { get; set; }
        public decimal? TotalSurtida { get; set; }
        public decimal? TotalPendiente { get; set; }
        public decimal CantApartada { get; set; }
        public short DiaSurtido { get; set; }
        public int? Ejecutivo { get; set; }
        public string CveEnvio { get; set; }
        public string Extraordinario { get; set; }
        public int? Cotizacion { get; set; }
        public bool? InterfazSap { get; set; }
        public string Descripcion { get; set; }
        public string ClavePedido { get; set; }
    }
}
