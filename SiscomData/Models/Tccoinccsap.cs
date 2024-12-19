using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinccsap
    {
        public int Sucursal { get; set; }
        public string Ccsap { get; set; }
        public string Descripcion { get; set; }
        public int? Cencos { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
