using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcocagastosdium
    {
        public int IdDetalle { get; set; }
        public int NumMov { get; set; }
        public short Sucursal { get; set; }
        public bool? AfectaSucursal { get; set; }
        public string Cuenta { get; set; }
        public int? Concepto { get; set; }
        public int? IdActivo { get; set; }
        public int? Sistema { get; set; }
        public decimal? Km { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string Factura { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Empleado { get; set; }
        public decimal? Retencion1 { get; set; }
        public decimal? Retencion2 { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
