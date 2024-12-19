using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcegssol
    {
        public int DetalleId { get; set; }
        public int Folio { get; set; }
        public DateTime FechaSol { get; set; }
        public int PacienteId { get; set; }
        public int EventoId { get; set; }
        public string Observaciones { get; set; }
        public bool Transmitido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
