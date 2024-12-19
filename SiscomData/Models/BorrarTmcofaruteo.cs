using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class BorrarTmcofaruteo
    {
        public short Suc { get; set; }
        public string Identificador { get; set; }
        public string TipoRuteo { get; set; }
        public string TipoProducto { get; set; }
        public int Ruta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
