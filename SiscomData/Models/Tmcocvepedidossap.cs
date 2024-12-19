using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocvepedidossap
    {
        public string TipoMovimiento { get; set; }
        public string ClaveDoc { get; set; }

        public virtual Tccocvepedidossap ClaveDocNavigation { get; set; }
    }
}
