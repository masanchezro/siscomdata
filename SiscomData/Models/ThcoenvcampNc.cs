using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcoenvcampNc
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? Devueltos { get; set; }
        public int? Auemntos { get; set; }
        public int? Cargas { get; set; }
        public int? SdoCargas { get; set; }
        public int? SdoDev { get; set; }
    }
}
