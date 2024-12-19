using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocagastosdium
    {
        public int Consec { get; set; }
        public short Sucursal { get; set; }
        public string Cuenta { get; set; }
        public short Contador { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public bool? ExcedePres { get; set; }
        public string Referencia { get; set; }
        public string TipoGasto { get; set; }
        public short SucAfecta { get; set; }
        public decimal? TipoIva { get; set; }
        public string Rfc { get; set; }
        public short? TipoOper { get; set; }
        public string Descripcion { get; set; }
        public string Ccsap { get; set; }
        public int Clave { get; set; }
        public string ClaveGasto { get; set; }
        public string Usuario { get; set; }
        public string CargoAbono { get; set; }
        public int IdAnticipoGasto { get; set; }
        public int Empleado { get; set; }
        public bool AfectaIngresoSuc { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
