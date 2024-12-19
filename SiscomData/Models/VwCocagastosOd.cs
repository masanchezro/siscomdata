using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocagastosOd
    {
        public int Consec { get; set; }
        public string TipoGasto { get; set; }
        public string TipoMov { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public decimal? Iva { get; set; }
        public short SucAfecta { get; set; }
        public string Referencia { get; set; }
        public short? TipoOper { get; set; }
        public string Rfc { get; set; }
        public bool AfectaIngresoSuc { get; set; }
        public int Clave { get; set; }
    }
}
