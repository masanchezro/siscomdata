using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenactualizacobro
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public int Recibo { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public string Movimiento { get; set; }
        public decimal? Importe { get; set; }
        public int? Antiguedad { get; set; }
    }
}
