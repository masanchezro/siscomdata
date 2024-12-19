using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxlistareceta
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
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Afiliacion { get; set; }
        public int? SubTipoCte { get; set; }
        public string TipoServicio { get; set; }
    }
}
