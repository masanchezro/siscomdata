using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocasaldosalterbono
    {
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string Rfc { get; set; }
        public string NombreCte { get; set; }
        public int Sector { get; set; }
        public string Descripcion { get; set; }
        public decimal? St { get; set; }
        public decimal? Sv { get; set; }
        public decimal? Sm90 { get; set; }
        public decimal? Smm90 { get; set; }
        public decimal? PorTotalMm90 { get; set; }
        public decimal? Acumulado { get; set; }
    }
}
