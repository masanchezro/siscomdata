using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocastatusseg
    {
        public Tccocastatusseg()
        {
            Tmcocamovs = new HashSet<Tmcocamov>();
        }

        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public short TipoMercado { get; set; }
        public int Orden { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccocatmerc TipoMercadoNavigation { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
    }
}
