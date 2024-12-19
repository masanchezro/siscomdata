using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoinproduccion
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public float? Cantidad { get; set; }
        public string FactRem { get; set; }
        public float? Capacidad { get; set; }
        public int Folio { get; set; }
        public int Cilindros { get; set; }
        public int Nota { get; set; }
    }
}
