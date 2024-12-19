using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoenruncampana
    {
        public string Mes { get; set; }
        public string TipoProcesoCampana { get; set; }
        public string Parametros { get; set; }
        public string Transmision { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
