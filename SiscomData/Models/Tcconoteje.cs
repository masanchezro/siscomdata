using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcconoteje
    {
        public Tcconoteje()
        {
            Tcconoejes = new HashSet<Tcconoeje>();
        }

        public int TipoEjecutivo { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public short? RangoIni { get; set; }
        public short? RangoFin { get; set; }

        public virtual ICollection<Tcconoeje> Tcconoejes { get; set; }
    }
}
