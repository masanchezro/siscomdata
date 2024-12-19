using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Trcocacobradorpromo
    {
        public int IdRelacion { get; set; }
        public int IdCobrador { get; set; }
        public int IdPromotora { get; set; }

        public virtual Tmcocacobradore IdCobradorNavigation { get; set; }
        public virtual Tmcocapromotora IdPromotoraNavigation { get; set; }
    }
}
