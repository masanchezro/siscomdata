using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcowmsrci
    {
        public long Idrci { get; set; }
        public string Folio { get; set; }
        public string Warehouse { get; set; }
        public string Account { get; set; }
        public string Supplier { get; set; }
        public string ReceiptType { get; set; }
        public string User { get; set; }
        public string DateConsulted { get; set; }
        public string OriginReference { get; set; }
        public string Lot { get; set; }
        public string Serial { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public string Footprint { get; set; }
        public string ExpirationDate { get; set; }
        public string AdmissionDate { get; set; }
        public string DinamicAttribute1 { get; set; }
        public string DinamicAttribute2 { get; set; }
        public string DinamicAttribute3 { get; set; }
        public string InventoryStatus { get; set; }
        public string Lpn { get; set; }
        public string Location { get; set; }
        public string Sku { get; set; }
        public string LargeDescription { get; set; }
        public string ReceiptReason { get; set; }
        public bool? Procesado { get; set; }
    }
}
