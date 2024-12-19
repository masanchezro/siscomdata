using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrperfil
    {
        public Tccogrperfil()
        {
            TrcogroperacionPerfils = new HashSet<TrcogroperacionPerfil>();
        }

        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TrcogroperacionPerfil> TrcogroperacionPerfils { get; set; }
    }
}
