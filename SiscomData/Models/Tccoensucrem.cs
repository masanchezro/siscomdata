using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoensucrem
    {
        public short? Sucursal { get; set; }
        public short? SucOrigen { get; set; }
        public short? SucDestino { get; set; }
        public string TipoRem { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
