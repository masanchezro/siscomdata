using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoentgarantium
    {
        public Tccoentgarantium()
        {
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
        }

        public byte IdTgarantia { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
    }
}
