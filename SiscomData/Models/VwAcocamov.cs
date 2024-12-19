using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwAcocamov
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public string TipoMovimiento { get; set; }
        public string TipoMovimientoOrigino { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? CargoPesos { get; set; }
        public decimal? AbonoPesos { get; set; }
        public decimal? CargoDlls { get; set; }
        public decimal? AbonoDlls { get; set; }
        public DateTime? FechaRefactura { get; set; }
        public decimal Importe { get; set; }
        public decimal? ImporteDlls { get; set; }
        public decimal? SaldoDlls { get; set; }
        public decimal? TipoCambio { get; set; }
        public string AnioMesProceso { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public int? SucursalOrigen { get; set; }
        public string TipoPago { get; set; }
        public string NoPago { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime? FechaCobro { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public short? Plazo { get; set; }
        public string CveMovto { get; set; }
        public string NombreBanco { get; set; }
        public int? Refactura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? ContraRecibo { get; set; }
        public string Descripcion { get; set; }
        public string Rfc { get; set; }
        public bool? Oxidom { get; set; }
        public string Estatus { get; set; }
        public short? Zonacobro { get; set; }
        public short? EjeGe { get; set; }
        public short? EjeGas { get; set; }
        public short? EjeMed { get; set; }
        public short? EjeMer { get; set; }
        public string NombreCliente { get; set; }
        public decimal? Periodo1 { get; set; }
        public decimal? Periodo2 { get; set; }
        public decimal? Periodo3 { get; set; }
        public decimal? Periodo4 { get; set; }
        public decimal? Periodo5 { get; set; }
        public decimal? Periodo6 { get; set; }
        public decimal? Periodo7 { get; set; }
        public decimal? Periodo8 { get; set; }
        public decimal? Periodo9 { get; set; }
        public decimal? Periodo10 { get; set; }
        public decimal? Periodo11 { get; set; }
        public decimal? Periodo12 { get; set; }
        public decimal? Periodo13 { get; set; }
        public decimal? Periodo14 { get; set; }
        public decimal? Periodo15 { get; set; }
        public decimal? Periodo16 { get; set; }
        public decimal? Periodo17 { get; set; }
        public decimal? Periodo18 { get; set; }
        public decimal? Periodo19 { get; set; }
        public decimal? Periodo20 { get; set; }
        public int? Ejecutivo { get; set; }
    }
}
