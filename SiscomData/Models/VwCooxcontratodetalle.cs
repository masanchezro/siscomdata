using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcontratodetalle
    {
        public int Cliente { get; set; }
        public int IdContrato { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? Cantidad { get; set; }
        public string NoSerie { get; set; }
        public string ImpCubrir { get; set; }
        public DateTime FechaAudit { get; set; }
        public DateTime FechaUtlSincronizacion { get; set; }
    }
}
