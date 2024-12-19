using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxcontrato
    {
        public int IdContrato { get; set; }
        public int Cliente { get; set; }
        public decimal MontoRenta { get; set; }
        public decimal Deposito { get; set; }
        public string Tecnico { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public DateTime? FechaUtlSincronizacion { get; set; }
    }
}
