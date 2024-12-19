using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcoidusoVistum
    {
        public int IdUsoVista { get; set; }
        public int IdUsuario { get; set; }
        public int? IdRibbonOption { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual TccoidribbonOption IdRibbonOptionNavigation { get; set; }
    }
}
