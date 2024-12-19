using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxcliente
    {
        public Tccooxcliente()
        {
            Tccooxclinicas = new HashSet<Tccooxclinica>();
        }

        public int IdClietesOx { get; set; }
        public int NumCteFirma { get; set; }
        public string Nombre { get; set; }
        public string FormaCobro { get; set; }
        public string TipoParticular { get; set; }
        public bool? CobroServUnificado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? CodigoFacturar { get; set; }
        public bool? ListadoEnAdeudo { get; set; }
        public double? MinimoRecetas { get; set; }
        public bool? FacturaXcliente { get; set; }
        public bool? UsaPrecioEspecial { get; set; }
        public bool? UsaListadoQuincenal { get; set; }
        public string TipoReporte { get; set; }
        public int? UsaPoliza { get; set; }
        public int? CobroConsumible { get; set; }
        public string CobConsFamilias { get; set; }

        public virtual ICollection<Tccooxclinica> Tccooxclinicas { get; set; }
    }
}
