using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoiddiasrecolec
    {
        public int Sucursal { get; set; }
        public DateTime? ProximaRecoleccion { get; set; }
        public bool? RecLunes { get; set; }
        public bool? RecMartes { get; set; }
        public bool? RecMiercoles { get; set; }
        public bool? RecJueves { get; set; }
        public bool? RecViernes { get; set; }
        public bool? RecSabado { get; set; }
        public string EntEvases { get; set; }
        public string DirEnvase { get; set; }
    }
}
