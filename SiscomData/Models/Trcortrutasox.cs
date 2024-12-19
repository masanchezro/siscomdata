using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Trcortrutasox
    {
        public short Grupo { get; set; }
        public string DescripcionGpo { get; set; }
        public short Ruta { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
