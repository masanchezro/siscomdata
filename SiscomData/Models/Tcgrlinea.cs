using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcgrlinea
    {
        public Tcgrlinea()
        {
            Thcoinmovs = new HashSet<Thcoinmov>();
            Tmcoinprod01s = new HashSet<Tmcoinprod01>();
        }

        public short Linea { get; set; }
        public string TipoLinea { get; set; }
        public string Descripcion { get; set; }
        public short? LineaPoliza { get; set; }
        public short? CvePoliza { get; set; }
        public short? LineaAgrupa { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Thcoinmov> Thcoinmovs { get; set; }
        public virtual ICollection<Tmcoinprod01> Tmcoinprod01s { get; set; }
    }
}
