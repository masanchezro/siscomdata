using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenmovsId
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Recibo { get; set; }
        public string Nombre { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? FechaMov { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Usuario { get; set; }
        public int? Idbanco { get; set; }
        public string Refbanco { get; set; }
        public string Tipopago { get; set; }
        public int Foliodep { get; set; }
    }
}
