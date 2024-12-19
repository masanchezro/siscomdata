using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinmovssinfamtro
    {
        public short Almacen { get; set; }
        public int Cliente { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int? Pedido { get; set; }
        public DateTime FechaMov { get; set; }
    }
}
