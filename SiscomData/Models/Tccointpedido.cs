using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccointpedido
    {
        public short IdTipoPedido { get; set; }
        public string TipoPedido { get; set; }
        public string ClavePedido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string TipoApartado { get; set; }
    }
}
