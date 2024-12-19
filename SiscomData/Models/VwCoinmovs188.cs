using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinmovs188
    {
        public int Codigo { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int Cilindros { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SaldoCant { get; set; }
        public int? ClienteSuc { get; set; }
        public short Linea { get; set; }
        public int NotaCredito { get; set; }
        public string Observaciones { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public string NumRemision { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteIva { get; set; }
        public int? NumRefactura { get; set; }
        public short IdTipoIva { get; set; }
        public decimal Descuento { get; set; }
        public string FormaPago { get; set; }
        public string DoctoFormaPago { get; set; }
        public string CondicionPago { get; set; }
        public string Rfc { get; set; }
        public bool Reparto { get; set; }
        public short? Ejecutivo { get; set; }
        public string MotivoNc { get; set; }
        public string Paquete { get; set; }
        public decimal? TipoCambio { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public decimal Tasa { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string NoSerie { get; set; }
        public string TipoProd { get; set; }
        public int? Almacen { get; set; }
    }
}
