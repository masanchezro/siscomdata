using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofavaloresdefaultaddendum
    {
        public string ClaveAddenda { get; set; }
        public int TipoAddenda { get; set; }
        public int IdCampoAddenda { get; set; }
        public int? Sucursal { get; set; }
        public string Valor { get; set; }
    }
}
