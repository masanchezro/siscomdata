using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcoencampRec
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public decimal? Deposito { get; set; }
        public int? DotacionTotal { get; set; }
        public int? Comsumos { get; set; }
    }
}
