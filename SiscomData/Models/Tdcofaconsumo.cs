using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofaconsumo
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public short Anio { get; set; }
        public short Mes { get; set; }
        public int? Cargas { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? ValoresMxp { get; set; }
        public decimal? ValoresDll { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcofaconsumo Tmcofaconsumo { get; set; }
    }
}
