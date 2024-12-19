using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcowmspci
    {
        public long Idpci { get; set; }
        public string Folio { get; set; }
        public string Warehouse { get; set; }
        public string Account { get; set; }
        public string PickingType { get; set; }
        public string User { get; set; }
        public string DateConsulted { get; set; }
        public string Lot { get; set; }
        public string Serial { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Weight { get; set; }
        public string Footprint { get; set; }
        public string ExpirationDate { get; set; }
        public string OutputDate { get; set; }
        public string DynamicAttribute1 { get; set; }
        public string DynamicAttribute2 { get; set; }
        public string DynamicAttribute3 { get; set; }
        public string InventoryStatus { get; set; }
        public string OrignLpn { get; set; }
        public string DestinationLpn { get; set; }
        public string Sku { get; set; }
        public string PickingReason { get; set; }
    }
}
