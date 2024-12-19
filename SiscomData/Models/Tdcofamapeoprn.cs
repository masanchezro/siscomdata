using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofamapeoprn
    {
        public int IdPrnValor { get; set; }
        public string ClaveAddenda { get; set; }
        public int TipoAddenda { get; set; }
        public int IdCampoAddenda { get; set; }
        public string CampoPrn { get; set; }

        public virtual Tmcofacamposaddendum Tmcofacamposaddendum { get; set; }
    }
}
