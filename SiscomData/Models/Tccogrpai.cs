using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrpai
    {
        public Tccogrpai()
        {
            Tccogredos = new HashSet<Tccogredo>();
            Tccogrpais2s = new HashSet<Tccogrpais2>();
            Tccogrsucs = new HashSet<Tccogrsuc>();
        }

        public string CodigoPais { get; set; }
        public string NombrePais { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tccogredo> Tccogredos { get; set; }
        public virtual ICollection<Tccogrpais2> Tccogrpais2s { get; set; }
        public virtual ICollection<Tccogrsuc> Tccogrsucs { get; set; }
    }
}
