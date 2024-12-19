using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrcontfianza
    {
        public int Cliente { get; set; }
        public string Tipo { get; set; }
        public string ConLiquidos { get; set; }
        public string ConGases { get; set; }
        public string ConOxidom { get; set; }
        public string Fianza { get; set; }
        public string Afianzadora { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
