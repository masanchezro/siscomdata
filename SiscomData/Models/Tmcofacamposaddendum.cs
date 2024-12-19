using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofacamposaddendum
    {
        public Tmcofacamposaddendum()
        {
            Tdcofamapeoprns = new HashSet<Tdcofamapeoprn>();
            Tdcofavaloresfijosaddenda = new HashSet<Tdcofavaloresfijosaddendum>();
        }

        public string ClaveAddenda { get; set; }
        public int TipoAddenda { get; set; }
        public int IdCampoAddenda { get; set; }
        public string NombreXml { get; set; }
        public string EtiquetaPantalla { get; set; }
        public string Descripcion { get; set; }
        public string TipoControl { get; set; }
        public bool? RequeridoXml { get; set; }
        public bool? Visible { get; set; }

        public virtual Tccofaaddendum Tccofaaddendum { get; set; }
        public virtual ICollection<Tdcofamapeoprn> Tdcofamapeoprns { get; set; }
        public virtual ICollection<Tdcofavaloresfijosaddendum> Tdcofavaloresfijosaddenda { get; set; }
    }
}
