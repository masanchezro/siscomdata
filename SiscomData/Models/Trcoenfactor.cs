using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Trcoenfactor
    {
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public short? DiasHabiles { get; set; }
        public decimal? Viajes { get; set; }
        public decimal? DiasSemana { get; set; }
        public decimal? FactorA { get; set; }
        public decimal? FactorB { get; set; }
        public int? EnvMtto { get; set; }
        public decimal? Capacidad { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
