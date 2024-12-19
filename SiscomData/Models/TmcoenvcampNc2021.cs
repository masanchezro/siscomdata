using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcoenvcampNc2021
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? Dotacion { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public int? EnvDev { get; set; }
        public int? EnvCambio { get; set; }
        public int? EnvIrrec { get; set; }
        public int? EnvActCons { get; set; }
        public int? EnvActDep { get; set; }
        public int? EnvVend { get; set; }
        public int? EnvActLr { get; set; }
        public short? NumCamp { get; set; }
    }
}
