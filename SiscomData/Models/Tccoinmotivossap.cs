using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinmotivossap
    {
        public int Linea { get; set; }
        public bool SoloGases { get; set; }
        public bool SoloMercancias { get; set; }
        public string TipoMovimiento { get; set; }
        public int IdMotivo { get; set; }
        public string DescMotivo { get; set; }
        public string Cuenta { get; set; }
        public string TipoCc { get; set; }
        public bool? CapturaCc { get; set; }
        public string TipoMovimientoSap { get; set; }
        public string TipoMovCancelacionSap { get; set; }
        public string Descripcion { get; set; }
        public string CatValoracion { get; set; }
    }
}
