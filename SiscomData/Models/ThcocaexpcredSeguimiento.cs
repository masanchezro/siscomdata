using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredSeguimiento
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? HoraLlamada { get; set; }
        public string Estatus { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool? Visible { get; set; }
        public int Id { get; set; }

        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
    }
}
