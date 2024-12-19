using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoidfichasrec
    {
        public string NoFicha { get; set; }
        public decimal? ImporteDeposito { get; set; }
        public string MetodoPago { get; set; }
        public DateTime? Fecha { get; set; }
        public string Boleta { get; set; }
        public string Moneda { get; set; }
        public int? Banco { get; set; }
        public DateTime? FechaBoleta { get; set; }
        public string NoSello { get; set; }
        public int? NoEnvase { get; set; }
    }
}
