using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccofaalmacendestino
    {
        public int Id { get; set; }
        public int? AlmacenOrigen { get; set; }
        public int? FolioPedido { get; set; }
        public int? AlmacenDestino { get; set; }
    }
}
