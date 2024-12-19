using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctcredlc
    {
        public int IdLimiteCredito { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoMov { get; set; }
        public string Anterior { get; set; }
        public string Actual { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCambio { get; set; }
        public string Observaciones { get; set; }

        public virtual Tmcoctcred Tmcoctcred { get; set; }
    }
}
