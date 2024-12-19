using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogroperacion
    {
        public Tccogroperacion()
        {
            TrcogroperacionPerfils = new HashSet<TrcogroperacionPerfil>();
        }

        public int IdOperacion { get; set; }
        public string NombreOperacion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TrcogroperacionPerfil> TrcogroperacionPerfils { get; set; }
    }
}
