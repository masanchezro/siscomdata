using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcocaclienterotacionSep2021
    {
        public short? Sucursal { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public int? Cliente { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? VentasMesActual { get; set; }
        public decimal? VentasPenutimoMes { get; set; }
        public decimal? VentasAntePenultimoMes { get; set; }
        public decimal? SaldoTotal { get; set; }
        public decimal? Ssv { get; set; }
        public decimal? S130 { get; set; }
        public decimal? S3160 { get; set; }
        public decimal? S6190 { get; set; }
        public decimal? S91120 { get; set; }
        public decimal? S121150 { get; set; }
        public decimal? S151180 { get; set; }
        public decimal? Sm180 { get; set; }
        public string Estatus { get; set; }
        public decimal? CobranzaMesActual { get; set; }
        public decimal? CobranzaPenultimoMes { get; set; }
        public decimal? CobranzaAntepenultimoMes { get; set; }
        public decimal? SDemanda { get; set; }
    }
}
