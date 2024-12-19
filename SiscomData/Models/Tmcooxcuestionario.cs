using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxcuestionario
    {
        public int CampaniaId { get; set; }
        public int PreguntaId { get; set; }
        public string Pregunta { get; set; }
        public string Tipo { get; set; }
        public bool? Estatus { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Usuario { get; set; }
    }
}
