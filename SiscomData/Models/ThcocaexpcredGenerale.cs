using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ThcocaexpcredGenerale
    {
        public ThcocaexpcredGenerale()
        {
            ThcocaexpcredContactos = new HashSet<ThcocaexpcredContacto>();
            ThcocaexpcredPagares = new HashSet<ThcocaexpcredPagare>();
            ThcocaexpcredSeguimientos = new HashSet<ThcocaexpcredSeguimiento>();
        }

        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public DateTime? FechaSolicitudCredito { get; set; }
        public bool? ActaConstitutiva { get; set; }
        public bool? PoderNotarial { get; set; }
        public bool? Comprobante { get; set; }
        public bool? Identificacion { get; set; }
        public bool? Rfc { get; set; }
        public string Observaciones { get; set; }
        public bool? Califica { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
        public virtual ThcocaexpcredLegal ThcocaexpcredLegal { get; set; }
        public virtual ThcocaexpcredProcedimiento ThcocaexpcredProcedimiento { get; set; }
        public virtual ICollection<ThcocaexpcredContacto> ThcocaexpcredContactos { get; set; }
        public virtual ICollection<ThcocaexpcredPagare> ThcocaexpcredPagares { get; set; }
        public virtual ICollection<ThcocaexpcredSeguimiento> ThcocaexpcredSeguimientos { get; set; }
    }
}
