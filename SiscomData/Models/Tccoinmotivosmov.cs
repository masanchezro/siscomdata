using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinmotivosmov
    {
        public int IdMotivo { get; set; }
        public string TipoMovimiento { get; set; }
        public bool Activo { get; set; }
        public string Motivo { get; set; }
    }
}
