using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Detalle
    {
        public double? Cliente { get; set; }
        public string Nombre { get; set; }
        public double? Folio { get; set; }
        public double? Fecha { get; set; }
        public double? Importe { get; set; }
    }
}
