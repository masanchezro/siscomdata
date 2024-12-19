using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocadiasrevcob
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Periodo { get; set; }
        public DateTime? DiaRevision { get; set; }
        public DateTime DiaCobro { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
