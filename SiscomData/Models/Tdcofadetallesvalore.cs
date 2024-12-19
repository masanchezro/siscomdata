using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofadetallesvalore
    {
        public int IdDetalles { get; set; }
        public string ClaveAddenda { get; set; }
        public int? TipoAddenda { get; set; }
        public string ClavePrn { get; set; }
        public string ClavePropiedadAddenda { get; set; }
        public string ValorPrn { get; set; }
        public string ValorReemplazo { get; set; }
    }
}
