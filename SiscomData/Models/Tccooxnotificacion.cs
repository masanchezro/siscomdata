using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxnotificacion
    {
        public Tccooxnotificacion()
        {
            Tccooxdestinatarios = new HashSet<Tccooxdestinatario>();
            Tccooxnotifnivconsumos = new HashSet<Tccooxnotifnivconsumo>();
        }

        public int NotificacionId { get; set; }
        public string Nombre { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }

        public virtual ICollection<Tccooxdestinatario> Tccooxdestinatarios { get; set; }
        public virtual ICollection<Tccooxnotifnivconsumo> Tccooxnotifnivconsumos { get; set; }
    }
}
