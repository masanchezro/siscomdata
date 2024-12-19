using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoenvisitadorcam
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int? Nomina { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
