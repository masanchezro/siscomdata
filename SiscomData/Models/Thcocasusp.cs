using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcocasusp
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public decimal? SalVen30 { get; set; }
        public bool? Autoriza30 { get; set; }
        public decimal? SalVen45 { get; set; }
        public bool? Autoriza45 { get; set; }
        public decimal? SalVen75 { get; set; }
        public bool? Autoriza75 { get; set; }
        public DateTime? FechaSuspension { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoctcred Tmcoctcred { get; set; }
    }
}
