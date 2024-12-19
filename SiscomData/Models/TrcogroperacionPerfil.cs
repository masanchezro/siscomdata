using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TrcogroperacionPerfil
    {
        public int IdOperacionPerfil { get; set; }
        public int IdOperacion { get; set; }
        public int IdPerfil { get; set; }
        public bool TienePermiso { get; set; }

        public virtual Tccogroperacion IdOperacionNavigation { get; set; }
        public virtual Tccogrperfil IdPerfilNavigation { get; set; }
    }
}
