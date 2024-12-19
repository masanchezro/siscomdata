using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoafdetalle
    {
        public Tccoafdetalle()
        {
            Tmcoafactivos = new HashSet<Tmcoafactivo>();
        }

        public int TipoActivo { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tccoaftipo TipoActivoNavigation { get; set; }
        public virtual ICollection<Tmcoafactivo> Tmcoafactivos { get; set; }
    }
}
