using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrtmov
    {
        public Tccogrtmov()
        {
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
            Tmcocamovs = new HashSet<Tmcocamov>();
        }

        public string Modulo { get; set; }
        public string TipoMovimiento { get; set; }
        public string Descripcion { get; set; }
        public string EntidadReferencia { get; set; }
        public bool? PermitirDespuesDelInforme { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
    }
}
