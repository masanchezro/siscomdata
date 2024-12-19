using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinprodbar
    {
        public int Codigo { get; set; }
        public string CodigoBarAlter { get; set; }
        public decimal? UnidadBarras { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
