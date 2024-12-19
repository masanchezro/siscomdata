using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoctentrega
    {
        public int IdDireccion { get; set; }
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string CodPos { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string GeoLon { get; set; }
        public string GeoLat { get; set; }
        public string Telefono { get; set; }
        public string Referencia { get; set; }
        public bool? TrasladoOxi { get; set; }
        public DateTime FechaAudit { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Usuario { get; set; }
        public string NombreCliente { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
