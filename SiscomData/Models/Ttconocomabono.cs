using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttconocomabono
    {
        public string Usuario { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public decimal? Abonos { get; set; }
        public decimal? ImpFac { get; set; }
    }
}
