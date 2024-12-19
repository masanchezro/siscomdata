using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofapromomayoreo
    {
        public string PromoMayoreo { get; set; }
        public string TipoFactura { get; set; }
        public int Codigo { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Maximo { get; set; }
        public string Grupo { get; set; }
        public string TipoDescuento { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
