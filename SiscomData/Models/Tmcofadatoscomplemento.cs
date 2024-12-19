using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofadatoscomplemento
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string EmailEnvioFe { get; set; }
        public string Cuenta { get; set; }
        public string Rfcbanco { get; set; }
        public string RazonSocial { get; set; }
        public string ClaveAddenda { get; set; }
    }
}
