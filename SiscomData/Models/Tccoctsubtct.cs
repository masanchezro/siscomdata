using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctsubtct
    {
        public Tccoctsubtct()
        {
            Tmcoctgrals = new HashSet<Tmcoctgral>();
        }

        public int IdSubTipoCliente { get; set; }
        public string IdTipoCliente { get; set; }
        public int IdVariante { get; set; }
        public string DescTipoCliente { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tmcoctgral> Tmcoctgrals { get; set; }
    }
}
