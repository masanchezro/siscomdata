using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofamenucatalogoaddendum
    {
        public Tmcofamenucatalogoaddendum()
        {
            Tdcofacatalogosaddenda = new HashSet<Tdcofacatalogosaddendum>();
        }

        public string ClaveAddenda { get; set; }
        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public int? MapPrincipal { get; set; }

        public virtual ICollection<Tdcofacatalogosaddendum> Tdcofacatalogosaddenda { get; set; }
    }
}
