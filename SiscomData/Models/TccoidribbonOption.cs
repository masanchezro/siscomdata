using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccoidribbonOption
    {
        public TccoidribbonOption()
        {
            ThcoidusoVista = new HashSet<ThcoidusoVistum>();
        }

        public int IdRibbonOption { get; set; }
        public int IdRibbonTab { get; set; }
        public string NombreRibbonOption { get; set; }
        public bool AfectaIngresos { get; set; }

        public virtual TccoidribbonTab IdRibbonTabNavigation { get; set; }
        public virtual ICollection<ThcoidusoVistum> ThcoidusoVista { get; set; }
    }
}
