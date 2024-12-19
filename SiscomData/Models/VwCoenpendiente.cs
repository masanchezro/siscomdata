using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenpendiente
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public short? SucOrigen { get; set; }
        public int Recibo { get; set; }
        public DateTime? Fecha { get; set; }
        public bool? EstatusEntrega { get; set; }
    }
}
