using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoindetallecodun
    {
        public short? Ruta { get; set; }
        public DateTime Fecha { get; set; }
        public int? Envases { get; set; }
        public int? Un { get; set; }
        public string Descripcion { get; set; }
        public decimal Riesgo1 { get; set; }
        public decimal Riesgo20 { get; set; }
        public decimal Riesgo21 { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? Pesoneto { get; set; }
        public decimal? Volumen { get; set; }
    }
}
