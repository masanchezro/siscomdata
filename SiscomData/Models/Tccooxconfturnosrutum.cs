using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxconfturnosrutum
    {
        public string Turno { get; set; }
        public string Descripcion { get; set; }
        public string HoraInicial { get; set; }
        public string HoraFinal { get; set; }
        public bool DiaSiguiente { get; set; }
        public bool Activo { get; set; }
    }
}
