using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinalmper
    {
        public int Almacen { get; set; }
        public string Usuario { get; set; }
        public bool Correo { get; set; }
        public bool Movimientos { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool Oxidom { get; set; }
    }
}
