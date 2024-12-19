using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxsaldosrutum
    {
        public int? Ruta { get; set; }
        public string NombreRuta { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int ClienteSuc { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public DateTime FechaMov { get; set; }
        public decimal Cantidad { get; set; }
        public int TipoProd { get; set; }
    }
}
