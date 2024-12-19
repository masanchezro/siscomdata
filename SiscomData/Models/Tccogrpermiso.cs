using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrpermiso
    {
        public int Id { get; set; }
        public int Sucursal { get; set; }
        public string IdPermiso { get; set; }
        public int Cliente { get; set; }
        public int FolioMovimiento { get; set; }
        public string CodigoAutorizacion { get; set; }
        public decimal? Cantidad { get; set; }
        public bool? Permiso { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Usuario { get; set; }
        public string Ccsap { get; set; }
    }
}
