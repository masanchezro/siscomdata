using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxfaclstpar
    {
        public int Id { get; set; }
        public int Idmovimiento { get; set; }
        public int FolioFactura { get; set; }
        public decimal? ImporteAplicado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
