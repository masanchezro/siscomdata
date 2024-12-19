using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxlistarecetasncparcial
    {
        public int Cliente { get; set; }
        public int Delegacion { get; set; }
        public int Clinica { get; set; }
        public int Sector { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string TipoCaptura { get; set; }
        public int? Dias { get; set; }
        public decimal? Importe { get; set; }
        public int? Folio { get; set; }
        public int? DiaIni { get; set; }
        public int? DiaFin { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Afiliacion { get; set; }
    }
}
