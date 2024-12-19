using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinunidaddi
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
        public string Conftransporte { get; set; }
        public string Modelo { get; set; }
        public decimal? PrimaSeg { get; set; }
        public string AsgCivil { get; set; }
        public string PolCivil { get; set; }
        public string AsgAmbiental { get; set; }
        public string PolAmbiental { get; set; }
        public string AsgCarga { get; set; }
        public string PolCarga { get; set; }
        public string Permsct { get; set; }
        public string Numpermisosct { get; set; }
    }
}
