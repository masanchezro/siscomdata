using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxdifequipo
    {
        public int? Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public string TipoCte { get; set; }
        public int? SubTipoCte { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public int? Codigo { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public DateTime? FecAltaEnv { get; set; }
        public short? Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int? Ccplanta { get; set; }
        public int? TipoProd { get; set; }
        public int Reguladores { get; set; }
        public string NvoAnio { get; set; }
    }
}
