using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoenfamilium
    {
        public Tccoenfamilium()
        {
            Trcoenfamilia = new HashSet<Trcoenfamilium>();
        }

        public short Familia { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Trcoenfamilium> Trcoenfamilia { get; set; }
    }
}
