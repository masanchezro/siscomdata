using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrbavanzadum
    {
        public int IdConsultaAvanzada { get; set; }
        public short IdModulo { get; set; }
        public string Descripcion { get; set; }
        public string CamposAocultar { get; set; }
        public string OrdenCampos { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
