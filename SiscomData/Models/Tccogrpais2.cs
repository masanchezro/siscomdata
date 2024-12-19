using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrpais2
    {
        public Tccogrpais2()
        {
            Tccogrestados = new HashSet<Tccogrestado>();
        }

        public string CodigoPais2 { get; set; }
        public string CodigoPais3 { get; set; }
        public string Pais { get; set; }
        public string FormatoCodPostal { get; set; }
        public string FormatoRit { get; set; }
        public string ValidacionRit { get; set; }
        public string Agrupacion { get; set; }

        public virtual Tccogrpai CodigoPais2Navigation { get; set; }
        public virtual ICollection<Tccogrestado> Tccogrestados { get; set; }
    }
}
