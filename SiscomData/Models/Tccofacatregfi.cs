using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofacatregfi
    {
        public Tccofacatregfi()
        {
            Thcoerrorfacs = new HashSet<Thcoerrorfac>();
            Tmcoctgrals = new HashSet<Tmcoctgral>();
        }

        public string TipoReg { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Thcoerrorfac> Thcoerrorfacs { get; set; }
        public virtual ICollection<Tmcoctgral> Tmcoctgrals { get; set; }
    }
}
