using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedpendenvsap
    {
        public long IdEnvio { get; set; }
        public short TipoPedido { get; set; }
        public int AlmacenCliente { get; set; }
        public int Proveedor { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool Enviado { get; set; }
        public bool Error { get; set; }
        public DateTime? UltimoIntento { get; set; }
        public string DoctoSap { get; set; }
        public string Ebeln { get; set; }
        public string MensajeWs { get; set; }
    }
}
