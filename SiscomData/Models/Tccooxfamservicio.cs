using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxfamservicio
    {
        public int IdFamiliaServicio { get; set; }
        public string Descripcion { get; set; }
        public int? Almacen { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Usuario { get; set; }
    }
}
