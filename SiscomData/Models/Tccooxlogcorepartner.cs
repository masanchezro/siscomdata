using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxlogcorepartner
    {
        public int IdLog { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public string Descripcion { get; set; }
    }
}
