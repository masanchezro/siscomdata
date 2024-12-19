using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogredo
    {
        public int IdEstado { get; set; }
        public string CodigoPais { get; set; }
        public string NombreEstado { get; set; }
        public string Abreviacion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccogrpai CodigoPaisNavigation { get; set; }
    }
}
