using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocttc
    {
        public Tccocttc()
        {
            Tmcoctgrals = new HashSet<Tmcoctgral>();
        }

        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tmcoctgral> Tmcoctgrals { get; set; }
    }
}
