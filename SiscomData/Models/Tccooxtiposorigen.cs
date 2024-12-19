using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxtiposorigen
    {
        public int IdTipo { get; set; }
        public string Descripcion { get; set; }
        public bool Estatus { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
