using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocptipopermiso
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string ClaveTransporte { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaVigencia { get; set; }
    }
}
