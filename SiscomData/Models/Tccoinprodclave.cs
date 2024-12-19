using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinprodclave
    {
        public Tccoinprodclave()
        {
            Tmcoinprod01s = new HashSet<Tmcoinprod01>();
        }

        public string IdClave { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcoinprod01> Tmcoinprod01s { get; set; }
    }
}
