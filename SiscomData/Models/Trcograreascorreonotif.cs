using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Trcograreascorreonotif
    {
        public int IdProcesoArea { get; set; }
        public string IdEmail { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccogrcorreonotif IdEmailNavigation { get; set; }
        public virtual Tccograreasnotif IdProcesoAreaNavigation { get; set; }
    }
}
