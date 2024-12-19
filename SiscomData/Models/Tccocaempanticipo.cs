using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccocaempanticipo
    {
        public short Sucursal { get; set; }
        public int Empleado { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tcconoemp Tcconoemp { get; set; }
    }
}
