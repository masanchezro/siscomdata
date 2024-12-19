using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenpatio
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? DotInicial { get; set; }
        public int AumCte { get; set; }
        public int DismCte { get; set; }
        public int AumSuc { get; set; }
        public int DismSuc { get; set; }
        public int AumPat { get; set; }
        public int DismPat { get; set; }
        public int? DotFinal { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
    }
}
