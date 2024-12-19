using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TtcotrIdentifica
    {
        public short? Sucursal { get; set; }
        public string Identificador { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
    }
}
