using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofadesolicitude
    {
        public int Id { get; set; }
        public int FolioPedido { get; set; }
        public string Proceso { get; set; }
        public string Nombre { get; set; }
        public string Valores { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime? FechaRuteo { get; set; }
    }
}
