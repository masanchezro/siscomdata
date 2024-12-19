using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccogrsucCodigosdir
    {
        public short Sucursal { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Localidad { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }

        public virtual Tccogrcolonium Co { get; set; }
        public virtual Tccogrestado EstadoNavigation { get; set; }
        public virtual Tccogrpais2 PaisNavigation { get; set; }
        public virtual Tccogrsuc SucursalNavigation { get; set; }
        public virtual Tccogrcp2 Tccogrcp2 { get; set; }
        public virtual Tccogrlocalidad Tccogrlocalidad { get; set; }
        public virtual Tccogrmunicipio Tccogrmunicipio { get; set; }
    }
}
