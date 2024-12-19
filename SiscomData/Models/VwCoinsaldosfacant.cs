using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinsaldosfacant
    {
        public short? Almacen { get; set; }
        public int Factura { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
