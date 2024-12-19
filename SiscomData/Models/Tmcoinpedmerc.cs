using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedmerc
    {
        public short TipoPedido { get; set; }
        public int AlmacenCliente { get; set; }
        public int Proveedor { get; set; }
        public int Pedido { get; set; }
        public int Codigo { get; set; }
        public int Partida { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public decimal CantSolicitada { get; set; }
        public decimal CantSurtida { get; set; }
        public decimal CantApartada { get; set; }
        public short DiaSurtido { get; set; }
        public int? Ejecutivo { get; set; }
        public string CveEnvio { get; set; }
        public string Extraordinario { get; set; }
        public int? Cotizacion { get; set; }
        public bool? InterfazSap { get; set; }
        public bool? Aprobado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string DoctoSap { get; set; }
        public string TipoPedidoSap { get; set; }
        public string OrgCompraSap { get; set; }
        public bool? EntregaFinal { get; set; }
        public decimal? CantProvSap { get; set; }
        public string UmprovSap { get; set; }
        public string ClasificacionPedido { get; set; }
        public byte? PartidaStatus { get; set; }
        public DateTime? FechaStatus { get; set; }
        public string UsuarioLibera { get; set; }
        public bool? PartidaCancelada { get; set; }
        public DateTime? FechaCencelada { get; set; }
        public string UsuarioCancela { get; set; }
    }
}
