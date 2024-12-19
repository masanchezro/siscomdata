using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcortproforma
    {
        public Tmcortproforma()
        {
            Tdcortproformas = new HashSet<Tdcortproforma>();
        }

        public short Sucursal { get; set; }
        public int Folio { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Cpostal { get; set; }
        public string Telefono { get; set; }
        public string GeoLat { get; set; }
        public string GeoLon { get; set; }
        public short? Ruta { get; set; }
        public int? OrdenRuta { get; set; }
        public string FiltroRuras { get; set; }
        public TimeSpan? InicioIntervaloHora { get; set; }
        public TimeSpan? FinIntervaloHora { get; set; }
        public int? DuracionDescarga { get; set; }
        public string TipoUnidad { get; set; }
        public bool? Reparto { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tdcortproforma> Tdcortproformas { get; set; }
    }
}
