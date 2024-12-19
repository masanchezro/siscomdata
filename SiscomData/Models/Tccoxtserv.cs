using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoxtserv
    {
        public Tccoxtserv()
        {
            Tmcooxservicios = new HashSet<Tmcooxservicio>();
        }

        public int IdTipoServicio { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcooxservicio> Tmcooxservicios { get; set; }
    }
}
