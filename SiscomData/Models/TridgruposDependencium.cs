using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TridgruposDependencium
    {
        public int IdGrupoDependencia { get; set; }
        public int IdGrupoPadre { get; set; }
        public int IdGrupoHijo { get; set; }

        public virtual Tcidgrupo IdGrupoHijoNavigation { get; set; }
        public virtual Tcidgrupo IdGrupoPadreNavigation { get; set; }
    }
}
