using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrcp2
    {
        public string CodigoPostal { get; set; }
        public string CodigoEstado { get; set; }
        public string CodigoMunicipio { get; set; }
        public string CodigoLocalidad { get; set; }

        public virtual Tccogrmunicipio Codigo { get; set; }
        public virtual Tccogrestado CodigoEstadoNavigation { get; set; }
    }
}
