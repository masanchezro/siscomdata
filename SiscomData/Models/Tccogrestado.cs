using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrestado
    {
        public Tccogrestado()
        {
            Tccogrcp2s = new HashSet<Tccogrcp2>();
            Tccogrlocalidads = new HashSet<Tccogrlocalidad>();
            Tccogrmunicipios = new HashSet<Tccogrmunicipio>();
        }

        public string CodigoEstado { get; set; }
        public string CodigoPais { get; set; }
        public string Estado { get; set; }

        public virtual Tccogrpais2 CodigoPaisNavigation { get; set; }
        public virtual ICollection<Tccogrcp2> Tccogrcp2s { get; set; }
        public virtual ICollection<Tccogrlocalidad> Tccogrlocalidads { get; set; }
        public virtual ICollection<Tccogrmunicipio> Tccogrmunicipios { get; set; }
    }
}
