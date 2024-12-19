using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcegspa
    {
        public int PacienteId { get; set; }
        public string Matricula { get; set; }
        public int GradoId { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FechaNac { get; set; }
        public int GeneroId { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool? Cancelado { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string FolioBaja { get; set; }
        public int? MotivoId { get; set; }
        public string UsuarioAlta { get; set; }
        public string UsuarioBaja { get; set; }
        public DateTime FechaAudit { get; set; }
        public string UsuarioAudit { get; set; }
    }
}
