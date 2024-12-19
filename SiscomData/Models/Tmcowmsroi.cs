using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcowmsroi
    {
        public long Idroi { get; set; }
        public int Almacen { get; set; }
        public int Clientesuc { get; set; }
        public int Pedido { get; set; }
        public string PedidoSap { get; set; }
        public string TipoMovimiento { get; set; }
        public int? Folio { get; set; }
        public string Facturaremision { get; set; }
        public DateTime? Fechapedido { get; set; }
        public string Account { get; set; }
        public string Warehouse { get; set; }
        public string Reason { get; set; }
        public string OrderType { get; set; }
        public string Supplier { get; set; }
        public string OrderNumber { get; set; }
        public string OriginReference { get; set; }
        public string BillNumber { get; set; }
        public string Waybill { get; set; }
        public string ExpiredDay { get; set; }
        public string Sku { get; set; }
        public string Product { get; set; }
        public string Footprint { get; set; }
        public decimal? OrderedQuantity { get; set; }
        public string Lot { get; set; }
        public string Serial { get; set; }
        public string DinamicAttribute1 { get; set; }
        public string DinamicAttribute2 { get; set; }
        public string DinamicAttribute3 { get; set; }
        public bool? IsReceiptDistribution { get; set; }
        public bool? IsQualityRequiered { get; set; }
        public bool? IsAuditRequiered { get; set; }
    }
}
