using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctrefbanco
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Referencia { get; set; }
        public int IdBanco { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Clabe { get; set; }

        public virtual Tccoctbanco IdBancoNavigation { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
