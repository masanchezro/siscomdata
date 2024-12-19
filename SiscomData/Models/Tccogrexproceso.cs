using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrexproceso
    {
        public int Id { get; set; }
        public short? Sucursal { get; set; }
        public string Proceso { get; set; }
        public string Modulo { get; set; }
    }
}
