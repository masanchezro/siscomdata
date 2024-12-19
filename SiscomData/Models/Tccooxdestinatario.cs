using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxdestinatario
    {
        public int DestinatarioId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int TipoCorreoId { get; set; }
        public int NotificacionId { get; set; }
        public bool? Estatus { get; set; }
        public int? NivelConsumoId { get; set; }

        public virtual Tccooxnotifnivconsumo NivelConsumo { get; set; }
        public virtual Tccooxnotificacion Notificacion { get; set; }
        public virtual Tccooxtipocorreo TipoCorreo { get; set; }
    }
}
