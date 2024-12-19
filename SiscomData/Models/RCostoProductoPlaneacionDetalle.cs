using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class RCostoProductoPlaneacionDetalle
    {
        public int? Renglon { get; set; }
        public string Abc { get; set; }
        public int? PosicionDistinguido { get; set; }
        public int? PosicionCte { get; set; }
        public string Nombre { get; set; }
        public string GrupoRfc { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Rfc { get; set; }
        public int? GrupoSec { get; set; }
        public string NombreGpoSec { get; set; }
        public decimal? Valores { get; set; }
        public decimal? Utilidad { get; set; }
        public string GrupoInst { get; set; }
    }
}
