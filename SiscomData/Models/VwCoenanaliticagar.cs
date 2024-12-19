using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenanaliticagar
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string FechaMov { get; set; }
        public int Recibo { get; set; }
        public int FolioDeposito { get; set; }
        public string TipoMovimiento { get; set; }
        public string Movimiento { get; set; }
        public short? Contrato { get; set; }
        public string TipoPago { get; set; }
        public string TransCheque { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? SaldoTot { get; set; }
        public string Observaciones { get; set; }
        public string Garantia { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
