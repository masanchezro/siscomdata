using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoenconteofi
    {
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Area { get; set; }
        public int Lote { get; set; }
        public int? Conteo1 { get; set; }
        public int? Conteo2 { get; set; }
        public int? Diferencia { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
