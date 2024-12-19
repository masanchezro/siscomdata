using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofapromo
    {
        public string NoPromocion { get; set; }
        public string Tipo { get; set; }
        public string FormaPromocion { get; set; }
        public string Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Objetivo { get; set; }
        public string Leyenda { get; set; }
        public decimal? PrecioEspecial { get; set; }
        public decimal? CantidadPermitida { get; set; }
    }
}
