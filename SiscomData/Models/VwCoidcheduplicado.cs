using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidcheduplicado
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NoPago { get; set; }
        public string NombreBanco { get; set; }
        public string NombreCliente { get; set; }
        public DateTime? FechaFactura { get; set; }
    }
}
