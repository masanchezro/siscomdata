using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxbintarjetum
    {
        public short Sucursal { get; set; }
        public int Bin { get; set; }
        public string Institucion { get; set; }
        public string Producto { get; set; }
        public string Naturaleza { get; set; }
        public bool? Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
