using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrmunicipio
    {
        public Tccogrmunicipio()
        {
            Tccogrcp2s = new HashSet<Tccogrcp2>();
        }

        public string CodigoMunicipio { get; set; }
        public string CodigoEstado { get; set; }
        public string Municipio { get; set; }

        public virtual Tccogrestado CodigoEstadoNavigation { get; set; }
        public virtual ICollection<Tccogrcp2> Tccogrcp2s { get; set; }
    }
}
