using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoincargasdium
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public string TipoSuc { get; set; }
        public DateTime FechaPedido { get; set; }
        public int? CjLleno { get; set; }
        public int? CjVacio { get; set; }
        public int? AuLleno { get; set; }
        public int? AuVacio { get; set; }
        public int? PaLleno { get; set; }
        public int? PaVacio { get; set; }
        public int? MaLleno { get; set; }
        public int? MaVacio { get; set; }
        public int? Dewar { get; set; }
        public string Acarreo { get; set; }
        public string Mer { get; set; }
        public string Chofer { get; set; }
    }
}
