using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoidcajausu
    {
        public int Sucursal { get; set; }
        public int Caja { get; set; }
        public string Nick { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? Activo { get; set; }
    }
}
