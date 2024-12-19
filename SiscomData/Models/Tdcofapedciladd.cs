using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofapedciladd
    {
        public int Idsol { get; set; }
        public int Tiposolicitud { get; set; }
        public string Nombre { get; set; }
        public string Elemento { get; set; }
        public bool? Valida { get; set; }
        public string Tablavalida { get; set; }
        public string Valores { get; set; }
        public string Mensaje { get; set; }
    }
}
