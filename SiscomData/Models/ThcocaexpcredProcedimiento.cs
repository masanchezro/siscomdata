using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredProcedimiento
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Paso1 { get; set; }
        public string Paso2 { get; set; }
        public string Paso3 { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
    }
}
