using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocamov
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoMovimiento { get; set; }
        public string TipoMovimientoOrigino { get; set; }
        public int NoDocumento { get; set; }
        public string Referencia { get; set; }
        public DateTime? FechaFactura { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime? FechaCobro { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public short? Plazo { get; set; }
        public decimal Importe { get; set; }
        public decimal Saldo { get; set; }
        public decimal? ImporteDlls { get; set; }
        public decimal SaldoDlls { get; set; }
        public decimal TipoCambio { get; set; }
        public string CveMovto { get; set; }
        public string NombreBanco { get; set; }
        public string AnioMesProceso { get; set; }
        public string Referencia2 { get; set; }
        public int? SucursalOrigen { get; set; }
        public string TipoPago { get; set; }
        public string NoPago { get; set; }
        public int? Refactura { get; set; }
        public DateTime? FechaRefactura { get; set; }
        public int? ContraRecibo { get; set; }
        public string Descripcion { get; set; }
        public string Rfc { get; set; }
        public bool? Oxidom { get; set; }
        public decimal CargoPesos { get; set; }
        public decimal AbonoPesos { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaSucursal { get; set; }
        public bool? OpcionFecha { get; set; }
        public string Clave { get; set; }
        public int? Ejecutivo { get; set; }
        public short? ZonaCobro { get; set; }
        public string TipoMercado { get; set; }
        public string NombreCliente { get; set; }
        public int DiasVencidos { get; set; }
        public string Usuario { get; set; }
        public int? Cabecera { get; set; }
    }
}
