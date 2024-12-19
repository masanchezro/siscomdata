using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinconpedidosrem
    {
        public long? Id { get; set; }
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public long Pedido { get; set; }
        public long? FolioTraspaso { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public short? Ruta { get; set; }
        public string Movimiento { get; set; }
    }
}
