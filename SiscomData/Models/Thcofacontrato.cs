using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcofacontrato
    {
        public string NoContrato { get; set; }
        public string TipoMovimiento { get; set; }
        public string ValorActual { get; set; }
        public string ValorNuevo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
