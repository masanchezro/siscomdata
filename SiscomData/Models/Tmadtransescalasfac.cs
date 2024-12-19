using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadtransescalasfac
    {
        public int Codigo { get; set; }
        public decimal? Factor { get; set; }
        public string UsuarioAudit { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
