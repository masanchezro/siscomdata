using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoenvtiporem
    {
        public Tccoenvtiporem()
        {
            Tmcoenvremisiones = new HashSet<Tmcoenvremisione>();
        }

        public string IdTipoRem { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcoenvremisione> Tmcoenvremisiones { get; set; }
    }
}
