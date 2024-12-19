using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinpedidorem
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public long Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? Envases { get; set; }
        public string Movimiento { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Metros { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public short? TiempoEntrega { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public long? FolioTraspaso { get; set; }
        public bool Traspasar { get; set; }
        public bool NoVisualizar { get; set; }
        public bool? Imprimir { get; set; }
        public bool? TraspasoLleno { get; set; }
        public short? Ruta { get; set; }
        public int? FolioEmbarque { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string UsuarioCancelo { get; set; }
        public string HostName { get; set; }
        public DateTime FechaEliminacion { get; set; }
    }
}
