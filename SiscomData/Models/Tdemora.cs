using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdemora
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Gas { get; set; }
        public string FechaCobro { get; set; }
        public short? DotacionInicial { get; set; }
        public short? Aumentos { get; set; }
        public short? Disminuciones { get; set; }
        public short? DotacionFinal { get; set; }
        public short? Compras { get; set; }
        public short? EnvaNoCalculados { get; set; }
        public short? EnvasesCobro { get; set; }
        public int? DiasCargo { get; set; }
        public int? DiasCredito { get; set; }
        public int? DiasAcobrar { get; set; }
        public decimal? CantidadAcobrar { get; set; }
        public bool? ClavePago { get; set; }
        public int? Factura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string MotivoMovimiento { get; set; }
        public string TipoCobro { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
