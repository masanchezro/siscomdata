using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoiddettpago
    {
        public int Idmodulo { get; set; }
        public string Modulo { get; set; }
        public int Clave { get; set; }
        public string TipoMovimiento { get; set; }
        public int? RefClave { get; set; }
        public bool? ActBanco { get; set; }
        public bool? ActCuenta { get; set; }
        public bool? ActNoPagp { get; set; }
    }
}
