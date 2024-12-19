using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredPagare
    {
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int Id { get; set; }

        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
    }
}
