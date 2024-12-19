using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinmaxurb
    {
        public int Planta { get; set; }
        public int Codigo { get; set; }
        public decimal MaximoUrb { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
