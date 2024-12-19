using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxrepvi
    {
        public int Id { get; set; }
        public string Sucursal { get; set; }
        public DateTime FechaImpresion { get; set; }
        public int CantidadImpresa { get; set; }
        public int? TipoCte { get; set; }
        public int? Cliente { get; set; }
        public bool? Trimestral { get; set; }
        public bool? BajasTrimestre { get; set; }
        public int? GrpRuta { get; set; }
        public int? Ruta { get; set; }
        public DateTime? FechaRuteoIni { get; set; }
        public DateTime? FechaRuteoFin { get; set; }
        public string Usuario { get; set; }
    }
}
