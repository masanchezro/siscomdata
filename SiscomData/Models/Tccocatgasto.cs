using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocatgasto
    {
        public Tccocatgasto()
        {
            Tccocacuentagastos = new HashSet<Tccocacuentagasto>();
        }

        public short Sucursal { get; set; }
        public string TipoCcsap { get; set; }
        public string Descripcion { get; set; }
        public string Ccsap { get; set; }

        public virtual ICollection<Tccocacuentagasto> Tccocacuentagastos { get; set; }
    }
}
