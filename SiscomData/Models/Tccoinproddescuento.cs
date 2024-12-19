using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinproddescuento
    {
        public int Codigo { get; set; }
        public short TipoDescuento { get; set; }
        public decimal? PorcentajeDescuento { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tccointdescuento TipoDescuentoNavigation { get; set; }
    }
}
