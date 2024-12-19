using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwDetallecomisonesmerc
    {
        public short? Mes { get; set; }
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int? Nomina { get; set; }
        public string NombreEje { get; set; }
        public short Ejecutivo { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Factura { get; set; }
        public DateTime? FecFac { get; set; }
        public string Cancelada { get; set; }
        public decimal? PendienteCobrar { get; set; }
        public decimal? Pagos { get; set; }
        public decimal? ImpContado { get; set; }
        public decimal? VentaSoloMes { get; set; }
        public decimal ImporteParaPago { get; set; }
        public int? OtSuc { get; set; }
        public decimal? PagoCalculado { get; set; }
        public decimal? PorcAplic { get; set; }
        public short? SucPago { get; set; }
        public short? SucPagadas { get; set; }
    }
}
