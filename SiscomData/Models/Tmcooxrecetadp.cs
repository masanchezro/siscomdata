using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxrecetadp
    {
        public int Id { get; set; }
        public int Sucursal { get; set; }
        public int TipoCte { get; set; }
        public int Delegacion { get; set; }
        public int Clinica { get; set; }
        public int Cliente { get; set; }
        public string TipoMovimiento { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string FolioReceta { get; set; }
        public int DiaIni { get; set; }
        public int DiaFin { get; set; }
        public int Dias { get; set; }
        public DateTime? DpfechaInicio { get; set; }
        public DateTime? DpfechaFin { get; set; }
        public string TipoServicio { get; set; }
        public int FolioFactura { get; set; }
        public string EstatusMov { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
