using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadrfcuniversal
    {
        public int Suc { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string CuentaUniversal { get; set; }
        public string CuentaClabe { get; set; }
        public string Cliente { get; set; }
        public int IdBanco { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
