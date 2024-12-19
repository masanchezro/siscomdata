using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofaaddendum
    {
        public Tccofaaddendum()
        {
            Tmcofacamposaddenda = new HashSet<Tmcofacamposaddendum>();
        }

        public string ClaveAddenda { get; set; }
        public string NombreAddenda { get; set; }
        public int TipoAddenda { get; set; }

        public virtual ICollection<Tmcofacamposaddendum> Tmcofacamposaddenda { get; set; }
    }
}
