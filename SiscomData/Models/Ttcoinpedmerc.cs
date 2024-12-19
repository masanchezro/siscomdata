using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoinpedmerc
    {
        public short Almacen { get; set; }
        public int Proveedor { get; set; }
        public int Pedido { get; set; }
        public int Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Extraordinario { get; set; }
        public decimal? Costo { get; set; }
        public string Autoriza { get; set; }
        public decimal? CantidadOriginal { get; set; }
    }
}
