using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoiddettpago
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int Idmodulo { get; set; }
        public string Modulo { get; set; }
        public string TipoMovimiento { get; set; }
        public int? RefClave { get; set; }
        public string DescReferencia { get; set; }
        public bool? ActBanco { get; set; }
        public bool? ActCuenta { get; set; }
        public bool? ActNoPagp { get; set; }
    }
}
