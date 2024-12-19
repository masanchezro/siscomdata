using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogriva
    {
        public Tccogriva()
        {
            Thcoinmovs = new HashSet<Thcoinmov>();
            Tmcocamovs = new HashSet<Tmcocamov>();
        }

        public short IdTipoIva { get; set; }
        public decimal Tasa { get; set; }
        public bool Frontera { get; set; }
        public string ClavePoliza { get; set; }

        public virtual ICollection<Thcoinmov> Thcoinmovs { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
    }
}
