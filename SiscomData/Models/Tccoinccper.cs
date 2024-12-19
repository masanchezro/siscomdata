using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoinccper
    {
        public short Sucursal { get; set; }
        public short Ccpermitida { get; set; }
        public int TipoProducto { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccogrsuc CcpermitidaNavigation { get; set; }
        public virtual Tccointprod TipoProductoNavigation { get; set; }
    }
}
