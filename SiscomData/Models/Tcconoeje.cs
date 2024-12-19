using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcconoeje
    {
        public short Sucursal { get; set; }
        public short NumeroEjecutivo { get; set; }
        public int Nomina { get; set; }
        public int TipoEjecutivo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public virtual Tcconoemp Tcconoemp { get; set; }
        public virtual Tcconoteje TipoEjecutivoNavigation { get; set; }
    }
}
