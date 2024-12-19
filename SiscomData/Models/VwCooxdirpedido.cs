using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxdirpedido
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int? Cliente { get; set; }
        public string Codpos { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Numext { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Municipio { get; set; }
        public string NumInt { get; set; }
        public int? Traslado { get; set; }
        public string GeoLat { get; set; }
        public string GeoLon { get; set; }
    }
}
