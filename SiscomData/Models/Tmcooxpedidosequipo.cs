using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxpedidosequipo
    {
        public short Sucursal { get; set; }
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Codigo { get; set; }
        public decimal Contrato { get; set; }
        public decimal Propiedad { get; set; }
        public int AlmacenOriginal { get; set; }
        public int AlmacenAsignado { get; set; }
        public int? Ruta { get; set; }
        public int? Operador { get; set; }
        public int? Unidad { get; set; }
        public int? Turno { get; set; }
        public string TipoPedido { get; set; }
        public string Estatus { get; set; }
        public bool? Facturado { get; set; }
        public bool? Concluido { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
