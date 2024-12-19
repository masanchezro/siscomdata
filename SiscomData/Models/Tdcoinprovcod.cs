using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinprovcod
    {
        public int IdInfo { get; set; }
        public int Proveedor { get; set; }
        public int Codigo { get; set; }
        public string Moneda { get; set; }
        public decimal? Costo { get; set; }
        public short? TiempoEnt { get; set; }
        public decimal? EmpaqueProv { get; set; }
        public string CodigoProv { get; set; }
        public DateTime FechaValIni { get; set; }
        public DateTime FechaValFin { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Usuario { get; set; }
        public decimal? CostoPesos { get; set; }
        public DateTime? FechaUltCompra { get; set; }
    }
}
