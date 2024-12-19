using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinnocaptura
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Marbete { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Existencia { get; set; }
    }
}
