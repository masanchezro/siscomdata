using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedimento1
    {
        public long IdConsecutivoPedimento { get; set; }
        public long IdConsecutivoMov { get; set; }
        public short Almacen { get; set; }
        public string NumPedimento { get; set; }
        public int Codigo { get; set; }
        public int NumeroPartida { get; set; }
        public int? ClienteSuc { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Pedido { get; set; }
        public bool IsTemporal { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
