﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttdcoinmovscod
    {
        public long IdConsecutivoMovCod { get; set; }
        public long IdConsecutivoMov { get; set; }
        public int Codigo { get; set; }
        public int NumeroPartida { get; set; }
        public int Cilindros { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal Descuento { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public string NumeroContrato { get; set; }
        public string NoSerie { get; set; }
        public decimal? PorcentajeIva { get; set; }
    }
}
