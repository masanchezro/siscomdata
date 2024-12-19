using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcotraccionespedweb
    {
        public long IdAccion { get; set; }
        public short? SucursalDestino { get; set; }
        public short? Sucursal { get; set; }
        public int? Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Cilindros { get; set; }
        public string Accion { get; set; }
        public string Aux1 { get; set; }
        public string Aux2 { get; set; }
        public string Aux3 { get; set; }
        public string Aux4 { get; set; }
        public string Aux5 { get; set; }
        public bool? Transmitir { get; set; }
    }
}
