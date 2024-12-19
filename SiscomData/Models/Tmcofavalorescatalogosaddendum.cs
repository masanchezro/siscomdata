using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofavalorescatalogosaddendum
    {
        public int IdMenu { get; set; }
        public int IdCampos { get; set; }
        public int IdValor { get; set; }
        public string Valor { get; set; }
        public int? MapeoAddenda { get; set; }

        public virtual Tdcofacatalogosaddendum Id { get; set; }
    }
}
