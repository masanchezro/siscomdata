using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinmovspedga
    {
        public long IdMovimiento { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Usuario { get; set; }

        public virtual Thcoinmov1 IdMovimientoNavigation { get; set; }
    }
}
