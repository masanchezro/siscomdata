using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoenerrorcorpo
    {
        public Tccoenerrorcorpo()
        {
            Tmcoencorpos = new HashSet<Tmcoencorpo>();
        }

        public short IdError { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual ICollection<Tmcoencorpo> Tmcoencorpos { get; set; }
    }
}
