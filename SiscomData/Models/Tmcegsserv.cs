using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcegsserv
    {
        public int ServicioId { get; set; }
        public string TipoServicio { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaServicio { get; set; }
        public string Archivo { get; set; }
        public string TipoArchivo { get; set; }
        public bool Transmitido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
