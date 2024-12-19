using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccoinunidaddisRe
    {
        public string NoEconomico { get; set; }
        public string Descripcion { get; set; }
        public string Matricula { get; set; }
        public string TipoUnidad { get; set; }
        public decimal? Peso { get; set; }
        public decimal? PesoCabina { get; set; }
        public decimal? PesoRampa { get; set; }
        public decimal? Largo { get; set; }
        public decimal? Ancho { get; set; }
        public decimal? Alto { get; set; }
        public bool? Activo { get; set; }
    }
}
