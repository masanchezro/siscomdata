using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxpagincentivo
    {
        public int MovimientoId { get; set; }
        public DateTime FechaRuteo { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Turno { get; set; }
        public int Nomina { get; set; }
        public string Nombre { get; set; }
        public int Nuevo { get; set; }
        public int Recargas { get; set; }
        public int Revision { get; set; }
        public int Traspaso { get; set; }
        public int Aumentos { get; set; }
        public int DisTotal { get; set; }
        public int DisPacial { get; set; }
        public int RevisionCobro { get; set; }
        public bool Transmitido { get; set; }
    }
}
