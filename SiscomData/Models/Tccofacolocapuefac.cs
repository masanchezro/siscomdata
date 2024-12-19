using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofacolocapuefac
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoDoc { get; set; }
        public bool? Activo { get; set; }
    }
}
