using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofapromocione
    {
        public string Promocion { get; set; }
        public string NoPromocion { get; set; }
        public string DescripcionGral { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool? HabilitarDescuentos { get; set; }
        public string PrecioEditable { get; set; }
        public bool? VerificaEjecutivo { get; set; }
        public bool? VerificaPrecioEspecial { get; set; }
        public string MetodoPago { get; set; }
        public string TipoCliente { get; set; }
        public bool? Visible { get; set; }
        public string MonedaPromocion { get; set; }
        public string PrecioTomar { get; set; }
        public decimal? CantidaPromo { get; set; }
    }
}
