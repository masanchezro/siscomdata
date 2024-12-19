using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccointdescuento
    {
        public Tccointdescuento()
        {
            Tccoinproddescuentos = new HashSet<Tccoinproddescuento>();
        }

        public short IdTipoDescuento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Tccoinproddescuento> Tccoinproddescuentos { get; set; }
    }
}
