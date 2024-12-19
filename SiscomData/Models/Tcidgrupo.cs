using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcidgrupo
    {
        public Tcidgrupo()
        {
            TridgruposDependenciumIdGrupoHijoNavigations = new HashSet<TridgruposDependencium>();
            TridgruposDependenciumIdGrupoPadreNavigations = new HashSet<TridgruposDependencium>();
            TridusuarioGrupos = new HashSet<TridusuarioGrupo>();
        }

        public int IdGrupo { get; set; }
        public string NombreGrupo { get; set; }

        public virtual ICollection<TridgruposDependencium> TridgruposDependenciumIdGrupoHijoNavigations { get; set; }
        public virtual ICollection<TridgruposDependencium> TridgruposDependenciumIdGrupoPadreNavigations { get; set; }
        public virtual ICollection<TridusuarioGrupo> TridusuarioGrupos { get; set; }
    }
}
