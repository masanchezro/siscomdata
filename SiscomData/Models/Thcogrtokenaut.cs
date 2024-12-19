using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcogrtokenaut
    {
        public int Id { get; set; }
        public string Modulo { get; set; }
        public int? SucursalOrigen { get; set; }
        public int? SucursalDestino { get; set; }
        public int? Cliente { get; set; }
        public string Token { get; set; }
        public string Clave { get; set; }
        public string Referencia { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
