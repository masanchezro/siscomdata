using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofavaloresfijosaddendum
    {
        public int IdCampoAddenda { get; set; }
        public int TipoAddenda { get; set; }
        public string ClaveAddenda { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string ValorAsociado { get; set; }

        public virtual Tmcofacamposaddendum Tmcofacamposaddendum { get; set; }
    }
}
