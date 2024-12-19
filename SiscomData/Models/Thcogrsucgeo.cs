using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcogrsucgeo
    {
        public short Sucursal { get; set; }
        public string GeoLat { get; set; }
        public string GeoLon { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
