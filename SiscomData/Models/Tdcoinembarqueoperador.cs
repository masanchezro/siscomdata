using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinembarqueoperador
    {
        public int Id { get; set; }
        public int? FolioEmbarque { get; set; }
        public int? Nomina { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string NumLicencia { get; set; }
    }
}
