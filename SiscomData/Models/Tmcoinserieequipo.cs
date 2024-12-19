using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinserieequipo
    {
        public int Sucursal { get; set; }
        public int Codigo { get; set; }
        public string NoSerie { get; set; }
        public string TipoSerie { get; set; }
        public int? Ubicacion { get; set; }
        public string TipoUbicacion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
