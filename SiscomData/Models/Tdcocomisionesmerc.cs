using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcocomisionesmerc
    {
        public short Ejecutivo { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Factura { get; set; }
        public decimal? ImporteFac { get; set; }
        public decimal? Cargos { get; set; }
        public decimal? Abonos { get; set; }
        public decimal? NotasCredCarg { get; set; }
        public decimal? SaldoCartera { get; set; }
        public decimal VtaMercancia { get; set; }
        public double? UniMercancia { get; set; }
        public decimal ImporteParaPago { get; set; }
        public decimal? ImpContado { get; set; }
        public double? UniContado { get; set; }
        public string TipoFac { get; set; }
        public DateTime? FechaVta { get; set; }
        public string NombreCte { get; set; }
        public string NombreEje { get; set; }
        public string NombreSuc { get; set; }
        public int? Nomina { get; set; }
        public decimal? PagoCalculado { get; set; }
        public decimal? VentaMes { get; set; }
        public short? SucPago { get; set; }
        public decimal? PorcAplic { get; set; }
        public short? TipoEje { get; set; }
        public short? SucPagadas { get; set; }
        public short? Mes { get; set; }
        public string Cancelada { get; set; }
    }
}
