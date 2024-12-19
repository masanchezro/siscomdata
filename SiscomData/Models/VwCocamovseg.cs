using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocamovseg
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public decimal? Importe { get; set; }
        public string EstatusSeguimiento { get; set; }
        public string DescripcionEstatus { get; set; }
        public string TipoMovimientoOrigino { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string AnioMesProceso { get; set; }
        public short? ZonaCobro { get; set; }
        public int? Ejecutivo { get; set; }
        public string Promotora { get; set; }
        public int? NumPromotora { get; set; }
        public string Usuario { get; set; }
    }
}
