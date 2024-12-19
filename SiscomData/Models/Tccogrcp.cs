using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrcp
    {
        public int CodigoPostal { get; set; }
        public string Colonia { get; set; }
        public string TipoColonia { get; set; }
        public string Municipio { get; set; }
        public string CodigoPais { get; set; }
        public int IdEstado { get; set; }
        public string Ciudad { get; set; }

        public virtual Tccogrpai CodigoPaisNavigation { get; set; }
        public virtual Tccogredo IdEstadoNavigation { get; set; }
    }
}
