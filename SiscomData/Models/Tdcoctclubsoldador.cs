using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoctclubsoldador
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NotarjetaClub { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
