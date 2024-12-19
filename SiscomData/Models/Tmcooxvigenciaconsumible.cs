using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxvigenciaconsumible
    {
        public int Sucursal { get; set; }
        public int Institucion { get; set; }
        public int Familia { get; set; }
        public int Codigo { get; set; }
        public int Vigencia { get; set; }
        public int Umbral { get; set; }
        public decimal Cantidad { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
