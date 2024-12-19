using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcofaerafectacione
    {
        public int Id { get; set; }
        public int? Sucursal { get; set; }
        public int? Cliente { get; set; }
        public int? Folio { get; set; }
        public string FormaFacturacion { get; set; }
        public string TipoFacturacion { get; set; }
        public DateTime? FechaAudit { get; set; }
        public int? ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
    }
}
