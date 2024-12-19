using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TridusuarioGrupo
    {
        public int IdUsuarioGrupo { get; set; }
        public int IdGrupo { get; set; }
        public int IdUsuario { get; set; }

        public virtual Tcidgrupo IdGrupoNavigation { get; set; }
        public virtual Tcidusuario IdUsuarioNavigation { get; set; }
    }
}
