using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocacomppago
    {
        public int Folio { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public decimal? Importe { get; set; }
        public string FormaPago { get; set; }
        public string NumeroOperacion { get; set; }
        public string RfcbancoEmisor { get; set; }
        public string NombreBancoEmisor { get; set; }
        public bool? Todos { get; set; }
    }
}
