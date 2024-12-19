using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TempSaldosComplemento
    {
        public short? Sucursal { get; set; }
        public short? Ccsucursal { get; set; }
        public int? Cliente { get; set; }
        public int? NoDocumento { get; set; }
        public short? Plazo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? CargoPesos { get; set; }
        public decimal? AbonosPesos { get; set; }
        public decimal? CargosDolares { get; set; }
        public decimal? AbonosDolares { get; set; }
        public int? SucOrigen { get; set; }
        public string TipomovimientoOrigino { get; set; }
        public decimal? SaldoPesos { get; set; }
        public decimal? SaldoDlls { get; set; }
    }
}
