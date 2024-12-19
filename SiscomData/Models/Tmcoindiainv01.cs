using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoindiainv01
    {
        public int Zona { get; set; }
        public int Codigo { get; set; }
        public decimal? Existencia { get; set; }
        public decimal? DiasInventario { get; set; }
        public int? NumProveedor { get; set; }
        public int? ZonaInfluencia { get; set; }
    }
}
