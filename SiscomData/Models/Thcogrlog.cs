using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcogrlog
    {
        public int IdLog { get; set; }
        public string Usuario { get; set; }
        public int NominaUsuario { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSalida { get; set; }
        public string EquipoConexion { get; set; }
    }
}
