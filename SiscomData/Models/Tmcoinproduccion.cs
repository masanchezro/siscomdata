using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinproduccion
    {
        public int Codigo { get; set; }
        public int Thermo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Capacidad { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
