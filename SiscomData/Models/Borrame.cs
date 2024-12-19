using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Borrame
    {
        public short Almacen { get; set; }
        public string Tipomovimiento { get; set; }
        public int Clientesuc { get; set; }
        public string Folio { get; set; }
        public int? Pedido { get; set; }
        public string Facturaremision { get; set; }
        public DateTime? Fechamov { get; set; }
        public int Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public string Numpedimento { get; set; }
        public string Tipotraspaso { get; set; }
    }
}
