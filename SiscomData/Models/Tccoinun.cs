using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinun
    {
        public int Un { get; set; }
        public string Descripcion { get; set; }
        public decimal Riesgo1 { get; set; }
        public string Rombo1 { get; set; }
        public decimal Riesgo20 { get; set; }
        public string Rombo2 { get; set; }
        public decimal Riesgo21 { get; set; }
        public string Rombo21 { get; set; }
        public short? TipoProd { get; set; }
    }
}
