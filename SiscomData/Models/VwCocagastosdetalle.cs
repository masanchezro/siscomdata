using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocagastosdetalle
    {
        public string TipoMantto { get; set; }
        public string Concepto { get; set; }
        public string Vehiculo { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Sistema { get; set; }
        public string Proveedor { get; set; }
        public string Placas { get; set; }
        public decimal Km { get; set; }
        public string Factura { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Usuario { get; set; }
    }
}
