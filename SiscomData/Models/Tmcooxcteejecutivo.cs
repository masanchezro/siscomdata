using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxcteejecutivo
    {
        public int Cliente { get; set; }
        public int Nomina { get; set; }
        public short? Activo { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }

        public virtual Tmcooxejecutivo NominaNavigation { get; set; }
    }
}
