using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcocatemporala01
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public decimal? Importe { get; set; }
        public string Error { get; set; }
        public string Procesado { get; set; }
        public int Id { get; set; }
    }
}
