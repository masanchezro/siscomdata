using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrlocalidad
    {
        public string CodigoLocalidad { get; set; }
        public string CodigoEstado { get; set; }
        public string Localidad { get; set; }

        public virtual Tccogrestado CodigoEstadoNavigation { get; set; }
    }
}
