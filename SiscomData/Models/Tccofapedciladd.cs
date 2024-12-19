using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofapedciladd
    {
        public int Id { get; set; }
        public string Proceso { get; set; }
        public bool? Solinfo { get; set; }
        public int? Tiposolicitud { get; set; }
        public string Signo { get; set; }
        public string Tipo { get; set; }
        public bool? Detalle { get; set; }
        public string Leyenda { get; set; }
    }
}
