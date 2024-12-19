using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxaltabajaCpapbpapcon
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int TipoServicio { get; set; }
        public string Servicio { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string TipoCte { get; set; }
        public string Equipo { get; set; }
        public string Observaciones { get; set; }
    }
}
