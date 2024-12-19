using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrtokenaut
    {
        public int Id { get; set; }
        public string Modulo { get; set; }
        public string Token { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
