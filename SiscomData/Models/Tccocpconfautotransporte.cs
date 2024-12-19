using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocpconfautotransporte
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string NumEjes { get; set; }
        public string NumLlanta { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
