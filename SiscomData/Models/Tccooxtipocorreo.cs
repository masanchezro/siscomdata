using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxtipocorreo
    {
        public Tccooxtipocorreo()
        {
            Tccooxdestinatarios = new HashSet<Tccooxdestinatario>();
        }

        public int TipoCorreoId { get; set; }
        public string TipoCorreo { get; set; }

        public virtual ICollection<Tccooxdestinatario> Tccooxdestinatarios { get; set; }
    }
}
