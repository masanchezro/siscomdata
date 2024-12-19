using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoendotideal
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int DotacionTotal { get; set; }
        public short Patios { get; set; }
        public int? Ideal { get; set; }
        public int? Exedente { get; set; }
        public int? Faltante { get; set; }
        public short Intocables { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
    }
}
