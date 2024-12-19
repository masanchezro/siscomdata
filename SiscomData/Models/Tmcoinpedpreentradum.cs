using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedpreentradum
    {
        public string DoctoSap { get; set; }
        public string DoctoPreEntrada { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CantProvSap { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool? Procesado { get; set; }
    }
}
