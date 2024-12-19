using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofapedctesauto
    {
        public short Sucursal { get; set; }
        public int Pedido { get; set; }
        public string TipoDocumento { get; set; }
        public string DesTipoDocto { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal Saldo { get; set; }
        public short ZonaCobro { get; set; }
        public short Ruta { get; set; }
        public short? Ejecutivo { get; set; }
        public string TipoPago { get; set; }
        public string DesTipoPago { get; set; }
        public DateTime? FechaFe { get; set; }
        public DateTime FechaPedidoHis { get; set; }
        public decimal? Total { get; set; }
        public string Estatus { get; set; }
        public string UsrCaptura { get; set; }
        public string UsrAutoriza { get; set; }
        public string UsuarioPedido { get; set; }
    }
}
