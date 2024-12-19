using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoidpolizasmov
    {
        public int Id { get; set; }
        public string TipoMovimientoPoliza { get; set; }
        public string PolizaClave { get; set; }
        public int? PolizaTipoIva { get; set; }
        public string PolizaTipoCliente { get; set; }
        public string PolizaCuenta { get; set; }
        public string Descripcion { get; set; }
        public bool? CuentaOxidom { get; set; }
        public bool? FaltaSap { get; set; }
        public string Indicador { get; set; }
    }
}
