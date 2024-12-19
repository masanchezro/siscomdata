using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxrentascte
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaUltRenta { get; set; }
        public int CodigoEnvases { get; set; }
        public int? DotacionFinal { get; set; }
        public int? FolioFactura { get; set; }
        public int? FolioAltaRenta { get; set; }
        public bool? ImprimirFactura { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Observaciones { get; set; }
        public string Pantalla { get; set; }

        public virtual Tmcooxcliente Tmcooxcliente { get; set; }
    }
}
