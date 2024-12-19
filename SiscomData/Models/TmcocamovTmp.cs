using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcocamovTmp
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public int? SucursalOrigen { get; set; }
        public string TipoMovimiento { get; set; }
        public string TipoPago { get; set; }
        public string NoPago { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime? FechaCobro { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public decimal? ImporteDlls { get; set; }
        public short? Plazo { get; set; }
        public string CveMovto { get; set; }
        public decimal TipoCambio { get; set; }
        public int? IdBanco { get; set; }
        public bool? Oxidom { get; set; }
        public int? Ejecutivo { get; set; }
        public int? Refactura { get; set; }
        public DateTime? FechaRefactura { get; set; }
        public int? ContraRecibo { get; set; }
        public string IdEstatusSeguimiento { get; set; }
        public DateTime? FechaEstatus { get; set; }
        public short? TipoIva { get; set; }
        public string AnioMesProceso { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public DateTime? FechaDeposito { get; set; }
        public decimal? MontoDeposito { get; set; }
        public string Tipo { get; set; }
        public string Procesar { get; set; }
        public string Contrato { get; set; }
        public string RfcBancoCte { get; set; }
        public string NombreBanco { get; set; }
        public string NumCuentaPago { get; set; }
        public int? Cabecera { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Tasa { get; set; }
        public decimal? SubTotalRetenciones { get; set; }
        public decimal? TasaRetenciones { get; set; }
        public string Uuidfac { get; set; }
    }
}
