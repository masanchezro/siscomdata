using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxformatob
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Institucion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }
        public DateTime? FechaLimite { get; set; }
        public string Vigente { get; set; }
        public string FormaCobroDesc { get; set; }
        public string Afiliacion { get; set; }
        public string Matricula { get; set; }
        public int CteFirma { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int FolioBaja { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
