using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoendemoracte
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Gas { get; set; }
        public string FechaCobro { get; set; }
        public short? DotacionFinal { get; set; }
        public short? Compras { get; set; }
        public short? EnvasesCobro { get; set; }
        public int? DiasCargo { get; set; }
        public int? DiasCredito { get; set; }
        public int? DiasAcobrar { get; set; }
        public decimal? CantidadAcobrar { get; set; }
        public string ClavePago { get; set; }
        public int Factura { get; set; }
        public string FechaFactura { get; set; }
        public string MotivoMovimiento { get; set; }
    }
}
