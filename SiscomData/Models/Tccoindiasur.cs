using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoindiasur
    {
        public int Sucursal { get; set; }
        public string DiaPedido { get; set; }
        public string DiaSurtimiento { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
