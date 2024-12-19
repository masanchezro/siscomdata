using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocatmerc
    {
        public Tccocatmerc()
        {
            Tccocastatussegs = new HashSet<Tccocastatusseg>();
            Tmcoctcreds = new HashSet<Tmcoctcred>();
        }

        public short IdMercado { get; set; }
        public string TipoMercado { get; set; }
        public int Rotacion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public int? Sector { get; set; }
        public int? ObjetivoBono { get; set; }

        public virtual ICollection<Tccocastatusseg> Tccocastatussegs { get; set; }
        public virtual ICollection<Tmcoctcred> Tmcoctcreds { get; set; }
    }
}
