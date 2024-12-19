using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoindiasuralter
    {
        public int Id { get; set; }
        public short? Sucursal { get; set; }
        public string DiaPedidoAlterno { get; set; }
        public string DiaSurtimientoAlterno { get; set; }
    }
}
