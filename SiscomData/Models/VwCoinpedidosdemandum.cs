using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinpedidosdemandum
    {
        public string TipoSuc { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Metros { get; set; }
        public decimal Existencia { get; set; }
        public decimal? Diferencia { get; set; }
    }
}
