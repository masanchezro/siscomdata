using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoindemandaace
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public DateTime FechaPedido { get; set; }
        public long Pedido { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? Cilindros { get; set; }
        public decimal? Metros { get; set; }
        public string Observaciones { get; set; }
        public int? Mov { get; set; }
        public string TipoSuc { get; set; }
    }
}
