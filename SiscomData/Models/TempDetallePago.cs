using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TempDetallePago
    {
        public short? Ccsucursal { get; set; }
        public int? Cliente { get; set; }
        public int? NoDocumento { get; set; }
        public string Numparcialidad { get; set; }
        public string Rfc { get; set; }
        public string NombreCliente { get; set; }
        public string Referencia { get; set; }
        public string Clave { get; set; }
        public string TipoPago { get; set; }
        public string NoPago { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteDlls { get; set; }
        public decimal? TipoCambio { get; set; }
        public int? IdBanco { get; set; }
        public int? SucOrigen { get; set; }
        public decimal? Cargopesos { get; set; }
        public decimal? AbonosPesos { get; set; }
        public decimal? CargosDolares { get; set; }
        public decimal? AbonosDolares { get; set; }
        public string Uuid { get; set; }
        public decimal? ImporteDocto { get; set; }
        public decimal? ImporteDoctoDlls { get; set; }
        public DateTime? FechaFactura { get; set; }
        public decimal? ImporteDr { get; set; }
        public string MetodoPagoDr { get; set; }
        public string MonedaDr { get; set; }
        public string TipoCambioDr { get; set; }
        public decimal? ImpSaldoAnt { get; set; }
        public decimal? ImpSaldoInsoluto { get; set; }
    }
}
