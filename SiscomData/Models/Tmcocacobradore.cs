using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocacobradore
    {
        public Tmcocacobradore()
        {
            Trcocacobradorpromos = new HashSet<Trcocacobradorpromo>();
        }

        public int IdCobrador { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Trcocacobradorpromo> Trcocacobradorpromos { get; set; }
    }
}
