using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoecpedido
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnit { get; set; }
        public decimal Importe { get; set; }
        public decimal? ImporteIva { get; set; }
        public decimal? FactorIva { get; set; }
        public string TipoProd { get; set; }
        public int? CantConsFacturable { get; set; }
        public int CantNc { get; set; }
    }
}
