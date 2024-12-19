using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofacatalogosaddendum
    {
        public Tdcofacatalogosaddendum()
        {
            Tmcofavalorescatalogosaddenda = new HashSet<Tmcofavalorescatalogosaddendum>();
        }

        public int IdMenu { get; set; }
        public int IdCampos { get; set; }
        public string NombreEtiqueta { get; set; }
        public int? Map { get; set; }

        public virtual Tmcofamenucatalogoaddendum IdMenuNavigation { get; set; }
        public virtual ICollection<Tmcofavalorescatalogosaddendum> Tmcofavalorescatalogosaddenda { get; set; }
    }
}
