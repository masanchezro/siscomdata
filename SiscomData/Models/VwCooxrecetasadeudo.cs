using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxrecetasadeudo
    {
        public short Sucursal { get; set; }
        public int? TipoCliente { get; set; }
        public short Delegacion { get; set; }
        public short Unidad { get; set; }
        public int Cliente { get; set; }
        public string FormaCobro { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public int? Dias { get; set; }
        public string EstatusMov { get; set; }
        public DateTime? Fechabaja { get; set; }
        public bool Cancelado { get; set; }
    }
}
