using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocagtoxml
    {
        public long? Id { get; set; }
        public short Sucursal { get; set; }
        public string TipoGasto { get; set; }
        public string Descripcion { get; set; }
        public string Rfc { get; set; }
        public decimal? Monto { get; set; }
    }
}
