using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class GeocodificadosOxi
    {
        public int Cliente { get; set; }
        public string Name { get; set; }
        public double? Ruta { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int CteEntrega { get; set; }
        public string Sucursal { get; set; }
        public string InicioIntervaloHorario { get; set; }
        public string FinIntervaloHorario { get; set; }
        public int? DuracionDescargaUnitaria { get; set; }
        public string AsignarRecursos { get; set; }
        public int? Penalizacion { get; set; }
        public string ExcluirRecursos { get; set; }
        public string Tipo { get; set; }
    }
}
