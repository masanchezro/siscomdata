using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrtraslado
    {
        public int Id { get; set; }
        public string TipoMovimiento { get; set; }
        public string Desripcion { get; set; }
        public string TipoAccion { get; set; }
        public string Tabla { get; set; }
    }
}
