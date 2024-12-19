using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcidusuario
    {
        public Tcidusuario()
        {
            Tmcogrnotificaciones = new HashSet<Tmcogrnotificacione>();
            TridusuarioGrupos = new HashSet<TridusuarioGrupo>();
        }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public virtual ICollection<Tmcogrnotificacione> Tmcogrnotificaciones { get; set; }
        public virtual ICollection<TridusuarioGrupo> TridusuarioGrupos { get; set; }
    }
}
