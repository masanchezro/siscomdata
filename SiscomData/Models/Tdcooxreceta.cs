using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxreceta
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Recetas { get; set; }

        public virtual Tmcooxcliente Tmcooxcliente { get; set; }
    }
}
