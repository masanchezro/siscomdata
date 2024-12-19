using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcocasaldoscarrotaciom
    {
        public int Area { get; set; }
        public short Suc { get; set; }
        public int Mes { get; set; }
        public int Tipomercado { get; set; }
        public double? SalSinVencer { get; set; }
        public double? SalVen130 { get; set; }
        public double? SalVen3160 { get; set; }
        public double? SalVen6190 { get; set; }
        public double? SalVen91120 { get; set; }
        public double? SalVen121150 { get; set; }
        public double? SalVen151180 { get; set; }
        public double? SalVenMas180 { get; set; }
        public double? CarteraMensual { get; set; }
        public double? Ventas1 { get; set; }
        public double? Ventas2 { get; set; }
        public double? Ventas3 { get; set; }
        public int? RotacionAnt { get; set; }
        public int? RotacionMes { get; set; }
        public string RotObjetivo { get; set; }
    }
}
