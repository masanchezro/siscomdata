using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcaprecetasacumulado
    {
        public int Cliente { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int DiaIni { get; set; }
        public int DiaFin { get; set; }
        public int Cobrados { get; set; }
        public int Cobrar { get; set; }
        public int Faltantes { get; set; }
        public int MaxIdCaptura { get; set; }
        public string TipoServicio { get; set; }
    }
}
