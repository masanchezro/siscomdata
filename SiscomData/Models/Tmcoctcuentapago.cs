using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctcuentapago
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NumCuentaPago { get; set; }
        public string Moneda { get; set; }
        public string NombreBanco { get; set; }
        public string FormaPago { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string RfcBancoCte { get; set; }

        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
