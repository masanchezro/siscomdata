using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoendemora
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int? Envases { get; set; }
        public decimal AdeudoAnt { get; set; }
        public decimal ImporteAct { get; set; }
        public decimal? Total { get; set; }
    }
}
