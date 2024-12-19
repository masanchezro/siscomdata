using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinpedexistencium
    {
        public short Almacen { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public decimal? Saldo { get; set; }
    }
}
