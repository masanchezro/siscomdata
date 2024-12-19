using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxadeudorenta2
    {
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? FolioAltaRenta { get; set; }
        public string NombreCte { get; set; }
        public int? DiasRenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaUltPago { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? AltaCliente { get; set; }
        public string Formapago { get; set; }
        public string NombreInst { get; set; }
        public string NombreClinica { get; set; }
    }
}
