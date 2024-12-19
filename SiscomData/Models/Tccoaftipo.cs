using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoaftipo
    {
        public Tccoaftipo()
        {
            Tccoafdetalles = new HashSet<Tccoafdetalle>();
        }

        public int IdActivo { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tccoafdetalle> Tccoafdetalles { get; set; }
    }
}
