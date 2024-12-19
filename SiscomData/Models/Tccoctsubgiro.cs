using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctsubgiro
    {
        public Tccoctsubgiro()
        {
            Tmcoctgrals = new HashSet<Tmcoctgral>();
        }

        public short IdSubGiro { get; set; }
        public short IdGiro { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tccoctgiro IdGiroNavigation { get; set; }
        public virtual ICollection<Tmcoctgral> Tmcoctgrals { get; set; }
    }
}
