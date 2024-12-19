using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Finaltransmitidum
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int Recibo { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public int? FolioDeposito { get; set; }
        public short? Contrato { get; set; }
        public short? Provisional { get; set; }
        public short? Propiedad { get; set; }
        public int? FacturaVta { get; set; }
        public string MovCorp { get; set; }
        public string TipoPago { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Saldo { get; set; }
        public string NumCheque { get; set; }
        public int? Banco { get; set; }
        public string Observaciones { get; set; }
        public short? SucOrigen { get; set; }
        public short? PtaOrigen { get; set; }
        public bool? EstatusEntrega { get; set; }
        public bool? IngresoCaja { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime? FechaRecolecta { get; set; }
        public byte? TipoGarantia { get; set; }
        public bool? TransferPago { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public int? ReciboCorpo { get; set; }
    }
}
