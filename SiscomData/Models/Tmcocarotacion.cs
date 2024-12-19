using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocarotacion
    {
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public int? Area { get; set; }
        public int? TipoMercado { get; set; }
        public decimal? SaldoSinVencer { get; set; }
        public decimal? Saldo130 { get; set; }
        public decimal? Saldo3160 { get; set; }
        public decimal? Saldo6190 { get; set; }
        public decimal? Saldo91120 { get; set; }
        public decimal? Saldo121150 { get; set; }
        public decimal? Saldo151180 { get; set; }
        public decimal? Saldom180M { get; set; }
        public decimal? CarteraMensual { get; set; }
        public decimal? MesAntepenultimo { get; set; }
        public decimal? MesPenultimo { get; set; }
        public decimal? MesActual { get; set; }
        public int? RotacionAnt { get; set; }
        public int? RoteciomMes { get; set; }
        public int? C21 { get; set; }
        public decimal? CobranzaMesActual { get; set; }
        public decimal? CobranzaPenultimoMes { get; set; }
        public decimal? CobranzaAntepenultimoMes { get; set; }
        public decimal? SDemanda { get; set; }
    }
}
