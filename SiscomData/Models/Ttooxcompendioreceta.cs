using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttooxcompendioreceta
    {
        public int Id { get; set; }
        public int TipoCte { get; set; }
        public int CteFactura { get; set; }
        public string Institucion { get; set; }
        public int Clinica { get; set; }
        public string ClinicaNom { get; set; }
        public int Delegacion { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public string TipoMovimiento { get; set; }
        public int PacientesAdeudo { get; set; }
        public int PacientesCobrados { get; set; }
        public int TotalPacientes { get; set; }
        public int AdeudoRecetas { get; set; }
        public int DiasAdeudo { get; set; }
        public decimal MontoAdeudo { get; set; }
        public int RecetasFacturadas { get; set; }
        public decimal DiasFacturados { get; set; }
        public decimal MontoFacturado { get; set; }
    }
}
