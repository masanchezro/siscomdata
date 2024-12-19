using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocacondetgto
    {
        public int IdConcepto { get; set; }
        public int Sistema { get; set; }
        public string ServicioDescripcion { get; set; }
        public string Incluye { get; set; }
        public string Proceso { get; set; }
        public decimal Costo { get; set; }
        public string Frecuencia { get; set; }
    }
}
