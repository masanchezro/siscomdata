using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Trcoenfamilium
    {
        public int Codigo { get; set; }
        public short Familia { get; set; }

        public virtual Tccoenfamilium FamiliaNavigation { get; set; }
    }
}
