using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoendotideal
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Codigo { get; set; }
        public int? Envases { get; set; }
        public string Pedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaTransmite { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tccogrsuc SucursalNavigation { get; set; }
    }
}
