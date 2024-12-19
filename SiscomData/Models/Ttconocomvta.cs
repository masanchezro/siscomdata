using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttconocomvta
    {
        public string Usuario { get; set; }
        public int? Ejecutivo { get; set; }
        public int? Cliente { get; set; }
        public int Tipoprod { get; set; }
        public int Lineaagrupa { get; set; }
        public string FamiliaAgrupa { get; set; }
        public int? Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Abonos { get; set; }
        public decimal? Contado { get; set; }
        public decimal? Total { get; set; }
    }
}
