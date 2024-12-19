using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofadatosfacturacion
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string ClaveAddenda { get; set; }
        public string EmailEnvioFe { get; set; }
        public bool? QuitarAddendaIt { get; set; }
        public string ValoresAddenda { get; set; }
    }
}
