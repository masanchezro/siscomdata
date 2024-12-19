using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinmov
    {
        public short Almacen { get; set; }
        public int NumeroPartida { get; set; }
        public int Codigo { get; set; }
        public short? Linea { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int NotaCredito { get; set; }
        public string TipoNotaCred { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public int? NumRemision { get; set; }
        public int? NumRefactura { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public short? IdTipoIva { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteIva { get; set; }
        public decimal? Descuento { get; set; }
        public string FormaPago { get; set; }
        public string DoctoFormaPago { get; set; }
        public string CondicionPago { get; set; }
        public int ClienteSuc { get; set; }
        public string Rfc { get; set; }
        public bool? Transito { get; set; }
        public bool Reparto { get; set; }
        public short? Ejecutivo { get; set; }
        public string MotivoNc { get; set; }
        public string Paquete { get; set; }
        public decimal? TipoCambio { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public bool? CveImpresion { get; set; }
        public bool? PedidoGas { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccogrsuc AlmacenNavigation { get; set; }
        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tccogriva IdTipoIvaNavigation { get; set; }
        public virtual Tcgrlinea LineaNavigation { get; set; }
        public virtual Thcoinobmov Thcoinobmov { get; set; }
    }
}
