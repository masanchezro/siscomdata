using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrnotificacione
    {
        public int IdNotificacion { get; set; }
        public int IdUsuario { get; set; }
        public string Modulo { get; set; }
        public string Mensage { get; set; }
        public string Asunto { get; set; }
        public bool Leido { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vigencia { get; set; }
        public short Recurrente { get; set; }

        public virtual Tcidusuario IdUsuarioNavigation { get; set; }
    }
}
