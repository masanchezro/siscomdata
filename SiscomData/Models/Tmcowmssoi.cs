using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcowmssoi
    {
        public long Idsoi { get; set; }
        public int Almacen { get; set; }
        public int Clientesuc { get; set; }
        public int Pedido { get; set; }
        public string PedidoSap { get; set; }
        public string TipoMovimiento { get; set; }
        public int? Folioinfra { get; set; }
        public string Facturaremision { get; set; }
        public DateTime? Fechapedido { get; set; }
        public string Folio { get; set; }
        public string ShipmentOrderStatus { get; set; }
        public string ShipmentReason { get; set; }
        public string Customer { get; set; }
        public string CreationDate { get; set; }
        public string Rma { get; set; }
        public string Route { get; set; }
        public bool? IsTmsPlanning { get; set; }
        public string SalesOrder { get; set; }
        public string ShipmentDate { get; set; }
        public string DeliveryDate { get; set; }
        public string Carrier { get; set; }
        public string Comments { get; set; }
        public bool? IsBackOrder { get; set; }
        public int? Priority { get; set; }
        public string DestinationAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public string Warehouse { get; set; }
        public string Account { get; set; }
        public string Sku { get; set; }
        public string Product { get; set; }
        public decimal? OrderedQuantity { get; set; }
        public string Project { get; set; }
        public string Footprint { get; set; }
        public string ExpirationDate { get; set; }
        public string ClientProduct { get; set; }
        public string SalesLineOrder { get; set; }
        public decimal? UnitCost { get; set; }
        public string Currency { get; set; }
        public bool? IsBackOrder2 { get; set; }
        public string Progression { get; set; }
        public string DestinationArea { get; set; }
        public string DestinationLocation { get; set; }
        public string Lot { get; set; }
        public string Serial { get; set; }
        public string DinamicAttribute1 { get; set; }
        public string DinamicAttribute2 { get; set; }
        public string DinamicAttribute3 { get; set; }
        public bool? IsPartial { get; set; }
        public string InventoryRotation { get; set; }
        public string Uom { get; set; }
        public bool? IsRounded { get; set; }
        public bool? IsCrossDock { get; set; }
        public int? DaysOnShelf { get; set; }
        public string AllocationRoute { get; set; }
        public string Lpn { get; set; }
    }
}
