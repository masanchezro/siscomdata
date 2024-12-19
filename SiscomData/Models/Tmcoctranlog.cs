using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctranlog
    {
        public long IdLog { get; set; }
        public string Proceso { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
        public string Categoria { get; set; }
        public string Archivo { get; set; }
    }
}
