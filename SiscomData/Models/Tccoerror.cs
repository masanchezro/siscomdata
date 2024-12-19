using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoerror
    {
        public Tccoerror()
        {
            Thcoerrorfacs = new HashSet<Thcoerrorfac>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Thcoerrorfac> Thcoerrorfacs { get; set; }
    }
}
