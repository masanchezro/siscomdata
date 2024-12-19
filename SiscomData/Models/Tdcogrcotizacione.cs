using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcogrcotizacione
    {
        public string NoCotizacion { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? TotalPartida { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Tasa { get; set; }

        public virtual Tmcogrcotizacion NoCotizacionNavigation { get; set; }
    }
}
