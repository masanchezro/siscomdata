using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCortdetallerutum
    {
        public short Ruta { get; set; }
        public int? Pedido { get; set; }
        public int Folio { get; set; }
        public int? Cliente { get; set; }
        public string Nombre { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Credito { get; set; }
        public decimal? Contado { get; set; }
        public DateTime? Fecharuteo { get; set; }
    }
}
