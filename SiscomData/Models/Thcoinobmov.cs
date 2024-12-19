using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinobmov
    {
        public Thcoinobmov()
        {
            Thcoinmovs = new HashSet<Thcoinmov>();
        }

        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public DateTime FechaMov { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<Thcoinmov> Thcoinmovs { get; set; }
    }
}
