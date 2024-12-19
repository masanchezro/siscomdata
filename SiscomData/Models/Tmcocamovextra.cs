using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocamovextra
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public string TipoMovimiento { get; set; }
        public string Dato1 { get; set; }
        public string Dato2 { get; set; }
        public string Dato3 { get; set; }
        public string Dato4 { get; set; }
        public string Dato5 { get; set; }
    }
}
