using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoctrefbancaria
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Referencia { get; set; }
        public int IdBanco { get; set; }
        public int SucBanco { get; set; }
        public string NomBanco { get; set; }
        public string Cuenta { get; set; }
        public int Convenio { get; set; }
        public string Moneda { get; set; }
        public string RfcBanco { get; set; }
    }
}
