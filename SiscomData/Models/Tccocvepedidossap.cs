using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocvepedidossap
    {
        public Tccocvepedidossap()
        {
            Tmcocvepedidossaps = new HashSet<Tmcocvepedidossap>();
        }

        public string ClaveDoc { get; set; }
        public string Descripcion { get; set; }
        public string Prefijo { get; set; }
        public int Longitud { get; set; }
        public string MascaraLongitud { get; set; }

        public virtual ICollection<Tmcocvepedidossap> Tmcocvepedidossaps { get; set; }
    }
}
