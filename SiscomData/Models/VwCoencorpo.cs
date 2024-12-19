using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencorpo
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int ReciboCorpo { get; set; }
        public int Recibo { get; set; }
        public short? SucursalEnv { get; set; }
        public short? IdError { get; set; }
        public string TipoError { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMov { get; set; }
        public string TipoMovimiento { get; set; }
        public short? Envases { get; set; }
        public decimal? Importe { get; set; }
        public string Observaciones { get; set; }
    }
}
