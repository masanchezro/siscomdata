using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcofapedidosautoriza
    {
        public short? Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int? Pedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public int? Cliente { get; set; }
        public string TipoPago { get; set; }
        public decimal? LimiteCredito { get; set; }
        public bool? Suspendido { get; set; }
        public decimal? Saldo { get; set; }
        public string Estatus { get; set; }
        public string UsuarioCaptura { get; set; }
        public string UsuarioAuto { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
