using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoctgiro
    {
        public Tccoctgiro()
        {
            Tccoctsubgiros = new HashSet<Tccoctsubgiro>();
        }

        public short IdGiro { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tccoctsubgiro> Tccoctsubgiros { get; set; }
    }
}
