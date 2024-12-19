using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcocapromotora
    {
        public int NumPromotora { get; set; }
        public int NumZona { get; set; }
        public int ZonaActual { get; set; }
        public int? ZonaAnterior { get; set; }

        public virtual Tmcocapromotora NumPromotoraNavigation { get; set; }
    }
}
