using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Obcfkm07
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaUltRenta { get; set; }
        public int? CodigoEnvases { get; set; }
        public float? DotacionFinal { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? FolioFactura { get; set; }
        public int? FolioAltaRenta { get; set; }
        public bool? NoImprimirFactura { get; set; }
    }
}
