using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttconocommov
    {
        public string Usuario { get; set; }
        public int? Ejecutivo { get; set; }
        public int Folio { get; set; }
        public int? Almacen { get; set; }
        public int? Clientesuc { get; set; }
        public int Codigo { get; set; }
        public short LineaAgrupa { get; set; }
        public short LineaVta { get; set; }
        public int TipoProd { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Importe { get; set; }
    }
}
