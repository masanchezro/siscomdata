using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoidinfdiario
    {
        public int Id { get; set; }
        public string TipoMovimiento { get; set; }
        public string DescripcionTm { get; set; }
        public string Descripcion { get; set; }
        public string TipoCreacion { get; set; }
        public string TipoAccionImporte { get; set; }
        public string Cuenta { get; set; }
        public string SelCuenta { get; set; }
        public string Tabla { get; set; }
        public string TipoAsignacion { get; set; }
        public string IndicadorIva { get; set; }
        public string OrdenInterna { get; set; }
        public string TipoCuenta { get; set; }
        public string FechaBase { get; set; }
        public string Ccsap { get; set; }
        public string Cbsap { get; set; }
        public string TipoImporte { get; set; }
        public string ClaveMon { get; set; }
        public string UsarPoliza { get; set; }
        public string DescPartida { get; set; }
    }
}
