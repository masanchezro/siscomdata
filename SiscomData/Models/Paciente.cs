using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Paciente
    {
        public int PacienteId { get; set; }
        public string Afiliacion { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime? FechaNac { get; set; }
        public int? GeneroId { get; set; }
        public int? EstadoId { get; set; }
        public int? MunicipioId { get; set; }
        public int? Cpid { get; set; }
        public string Calle { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public double? Peso { get; set; }
        public double? Estatura { get; set; }
        public int? ClinicaId { get; set; }
        public int? MedicoId { get; set; }
        public string Observaciones { get; set; }
        public string ObservacionesCarga { get; set; }
        public DateTime? FechaAlta { get; set; }
        public short? SucursalId { get; set; }
        public string CteSiscom { get; set; }
        public int? SucSiscom { get; set; }
        public bool? EqpConEstudio { get; set; }
        public int? TecnicoId { get; set; }
    }
}
