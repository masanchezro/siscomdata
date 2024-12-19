using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofacounval
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public int TipoProd { get; set; }
        public short Anio { get; set; }
        public short Mes { get; set; }
        public int Cargas { get; set; }
        public decimal Unidades { get; set; }
        public decimal ValoresMxp { get; set; }
        public decimal ValoresDll { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public decimal? TotalUnidades { get; set; }
        public decimal? TotalValores { get; set; }
        public decimal? AcumuladoUnidades { get; set; }
        public decimal? AcumuladoValores { get; set; }
        public decimal AcumuladoUnidadesAnterior { get; set; }
        public decimal AcumuladosValoresAnterior { get; set; }
        public decimal AcumuladoUnidadesActual { get; set; }
        public decimal AcumuladosValoresActual { get; set; }
    }
}
