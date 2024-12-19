using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxnotifnivconsumo
    {
        public Tccooxnotifnivconsumo()
        {
            Tccooxdestinatarios = new HashSet<Tccooxdestinatario>();
        }

        public int NivelConsumoId { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public decimal PorcentajeConsumo { get; set; }
        public int NotificacionId { get; set; }

        public virtual Tccooxnotificacion Notificacion { get; set; }
        public virtual ICollection<Tccooxdestinatario> Tccooxdestinatarios { get; set; }
    }
}
