using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccoidribbonTab
    {
        public TccoidribbonTab()
        {
            TccoidribbonOptions = new HashSet<TccoidribbonOption>();
        }

        public int IdRibbonTab { get; set; }
        public string NombreRibbonTab { get; set; }

        public virtual ICollection<TccoidribbonOption> TccoidribbonOptions { get; set; }
    }
}
