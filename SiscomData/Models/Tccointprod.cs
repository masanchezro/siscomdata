using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccointprod
    {
        public Tccointprod()
        {
            Tccoinccpers = new HashSet<Tccoinccper>();
            Tmcoinprod01s = new HashSet<Tmcoinprod01>();
        }

        public int IdTipoProd { get; set; }
        public string TipoProd { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Tccoinccper> Tccoinccpers { get; set; }
        public virtual ICollection<Tmcoinprod01> Tmcoinprod01s { get; set; }
    }
}
