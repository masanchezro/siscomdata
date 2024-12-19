using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrbusq
    {
        public int IdBusquedaAbierta { get; set; }
        public string Usuario { get; set; }
        public string Descripcion { get; set; }
        public string Campos { get; set; }
        public string Operadores { get; set; }
        public string Valores { get; set; }
        public int Modulo { get; set; }
        public DateTime FechaAudit { get; set; }
        public string CamposMostrados { get; set; }
        public string CamposOrden { get; set; }
    }
}
