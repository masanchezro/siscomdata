using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcocarotcte
    {
        public int Cliente { get; set; }
        public decimal Saldo { get; set; }
        public decimal MesActual { get; set; }
        public decimal MesPenultimo { get; set; }
        public decimal MesAntepenultimo { get; set; }
        public decimal SaldoTotal { get; set; }
        public decimal Saldosinvencer { get; set; }
        public decimal V0130 { get; set; }
        public decimal V3160 { get; set; }
        public decimal V6190 { get; set; }
        public decimal V91120 { get; set; }
        public decimal V121150 { get; set; }
        public decimal V151180 { get; set; }
        public decimal V180 { get; set; }
        public decimal? CobranzaMesActual { get; set; }
        public decimal? CobranzaMesPenultimo { get; set; }
        public decimal? CobranzaMesAntepenultimo { get; set; }
        public decimal? Sm90 { get; set; }
        public decimal? Smm90 { get; set; }
        public decimal? Rotacion { get; set; }
        public short Plazo { get; set; }
        public decimal? CalifCliente { get; set; }
        public decimal LimiteCredito { get; set; }
    }
}
