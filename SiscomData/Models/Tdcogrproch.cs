using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcogrproch
    {
        public Tdcogrproch()
        {
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
            Tdcofapagosfacturas = new HashSet<Tdcofapagosfactura>();
            Tmcocamovs = new HashSet<Tmcocamov>();
        }

        public string NumCheque { get; set; }
        public string TipoMov { get; set; }
        public int FolioMov { get; set; }
        public string SucBanco { get; set; }
        public string CtaCheque { get; set; }
        public string CveProchemex { get; set; }
        public bool? Certificado { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
        public virtual ICollection<Tdcofapagosfactura> Tdcofapagosfacturas { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
    }
}
