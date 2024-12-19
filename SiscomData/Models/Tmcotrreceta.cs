using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcotrreceta
    {
        public int Id { get; set; }
        public int Idws { get; set; }
        public string IdTransaccion { get; set; }
        public int? Delegacion { get; set; }
        public string Folio { get; set; }
        public string Nss { get; set; }
        public string NoAfiliacion { get; set; }
        public string AgrMedico { get; set; }
        public int? Unidad { get; set; }
        public string MatriculaMed { get; set; }
        public string Diagnostico { get; set; }
        public string DiagnosticoDetalle { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int? Flujo { get; set; }
        public int? Periodo { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? NvaFechaFin { get; set; }
        public string Motivo { get; set; }
        public int? QuitaUltDia { get; set; }
        public string NoPaciente { get; set; }
        public int? TipoMovimiento { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
