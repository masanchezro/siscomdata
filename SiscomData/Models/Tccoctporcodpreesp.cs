using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctporcodpreesp
    {
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
