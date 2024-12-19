using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxrtcont
    {
        public int Cliente { get; set; }
        public int Sucursal { get; set; }
        public int Ruta { get; set; }
        public string Dia { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
