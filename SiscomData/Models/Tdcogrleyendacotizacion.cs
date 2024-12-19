using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcogrleyendacotizacion
    {
        public string NoCotizacion { get; set; }
        public string IdLeyenda { get; set; }

        public virtual Tmcogrcotizacion NoCotizacionNavigation { get; set; }
    }
}
