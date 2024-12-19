using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofaruta
    {
        public Tmcofaruta()
        {
            Tmcofaruteos = new HashSet<Tmcofaruteo>();
        }

        public int Ruta { get; set; }
        public string Tipo { get; set; }
        public string DescripcionRuta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcofaruteo> Tmcofaruteos { get; set; }
    }
}
