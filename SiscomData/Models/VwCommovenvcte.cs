using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCommovenvcte
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public short? EnvProv { get; set; }
        public decimal? Deposito { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public DateTime FechaUltConsumo { get; set; }
        public DateTime FechaBaja { get; set; }
        public int DiasTrans { get; set; }
    }
}
