using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCortdetalle
    {
        public short? Ruta { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Cilindros { get; set; }
        public string Um { get; set; }
        public decimal? Credito { get; set; }
        public decimal? Contado { get; set; }
        public int? TipoProd { get; set; }
        public DateTime? Fecharuteo { get; set; }
    }
}
