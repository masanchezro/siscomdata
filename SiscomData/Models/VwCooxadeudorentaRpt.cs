using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxadeudorentaRpt
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Direccion { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaUltRenta { get; set; }
        public int? DiasRenta { get; set; }
        public short? EnvCont { get; set; }
        public decimal? Importe { get; set; }
    }
}
