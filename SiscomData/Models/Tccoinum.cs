using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinum
    {
        public Tccoinum()
        {
            Tmcoinprod01s = new HashSet<Tmcoinprod01>();
        }

        public int IdUm { get; set; }
        public string Um { get; set; }
        public string UmSat { get; set; }
        public string Tipo { get; set; }
        public string UmSatCod { get; set; }

        public virtual ICollection<Tmcoinprod01> Tmcoinprod01s { get; set; }
    }
}
