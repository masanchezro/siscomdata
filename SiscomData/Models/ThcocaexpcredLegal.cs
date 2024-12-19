using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredLegal
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public bool ConAbogado { get; set; }
        public bool Demandado { get; set; }
        public DateTime? FechaDemanda { get; set; }
        public string FolioDemanda { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
    }
}
