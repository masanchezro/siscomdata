using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcorthorario
    {
        public int IdHorario { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public TimeSpan? IntervaloIni { get; set; }
        public TimeSpan? IntervaloFin { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string TipoUnidad { get; set; }
    }
}
