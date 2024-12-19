using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinpedidosrem
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public long Pedido { get; set; }
        public long? FolioTraspaso { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public short? Ruta { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Canje { get; set; }
        public int? AumentoLleno { get; set; }
        public int? AumentoVacios { get; set; }
        public int? PartLleno { get; set; }
        public int? PartVacios { get; set; }
        public int? MantoLleno { get; set; }
        public int? MantoVacios { get; set; }
        public string TipoSuc { get; set; }
    }
}
