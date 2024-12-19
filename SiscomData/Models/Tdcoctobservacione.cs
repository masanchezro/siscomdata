using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoctobservacione
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Observaciones { get; set; }
        public string DocumentoPresenta { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
