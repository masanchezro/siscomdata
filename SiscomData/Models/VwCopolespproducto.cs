using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCopolespproducto
    {
        public int Codigo { get; set; }
        public int CodigoRenta { get; set; }
        public string TipoServ { get; set; }
        public int? FamiliaServicio { get; set; }
        public string Descripcion { get; set; }
        public decimal? ImporteDeposito { get; set; }
    }
}
