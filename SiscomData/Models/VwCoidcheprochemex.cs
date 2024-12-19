using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidcheprochemex
    {
        public string NumCheque { get; set; }
        public string TipoMov { get; set; }
        public string Descripcion { get; set; }
        public int FolioMov { get; set; }
        public string SucursalProchemex { get; set; }
        public string CveProchemex { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Certificado { get; set; }
    }
}
