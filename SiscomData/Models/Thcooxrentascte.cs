using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxrentascte
    {
        public int MovimientoId { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int CodigoEnvases { get; set; }
        public DateTime FechaUtlRentaAnt { get; set; }
        public DateTime FechaUtlRentaAct { get; set; }
        public int DotacionFinal { get; set; }
        public int FolioFacturaAnt { get; set; }
        public int FolioFacturaAct { get; set; }
        public string UsuarioAnt { get; set; }
        public string UsuarioAct { get; set; }
        public DateTime FechaMovAnt { get; set; }
        public DateTime FechaAudit { get; set; }
        public string ObservacionesAnt { get; set; }
        public string ObservacionesAct { get; set; }
        public string TipoMovimiento { get; set; }
        public string Pantalla { get; set; }
    }
}
