using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoindistribucion
    {
        public int IdDistMatriz { get; set; }
        public long Pedido { get; set; }
        public int Codigo { get; set; }
        public decimal? Envases { get; set; }
        public short? Almacen { get; set; }
        public DateTime FechaPedido { get; set; }
        public short? TiempoEntrega { get; set; }
        public decimal? CantSurtida { get; set; }
        public short Movimiento { get; set; }
        public decimal? CantidadSolicitada { get; set; }
        public decimal? Metros { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public int? FolioTraspaso { get; set; }
        public bool Traspasar { get; set; }
        public bool NoVisualizar { get; set; }
        public bool? Imprimir { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
