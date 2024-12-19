using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdadtransescala
    {
        public int IdTransEscala { get; set; }
        public int IdDetTransEscala { get; set; }
        public int? Codigo { get; set; }
        public decimal? TopeEscala { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }
    }
}
