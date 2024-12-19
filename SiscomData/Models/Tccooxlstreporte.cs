using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxlstreporte
    {
        public int ReporteId { get; set; }
        public int SucursalId { get; set; }
        public string Modulo { get; set; }
        public string TituloReporte { get; set; }
        public string Procedured { get; set; }
        public string Spparams { get; set; }
        public string Rdcl { get; set; }
        public bool? EstatusReporte { get; set; }
        public string Usuario { get; set; }
        public string FechaAudit { get; set; }
        public string Reporte { get; set; }
    }
}
