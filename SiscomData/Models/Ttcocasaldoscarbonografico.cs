using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcocasaldoscarbonografico
    {
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Rfc { get; set; }
        public int Factura { get; set; }
        public short? Plazo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? FechaRealFactura { get; set; }
        public string TipoMonedaDocumento { get; set; }
        public int? Dias { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Sv { get; set; }
        public decimal? V0130 { get; set; }
        public decimal? V3160 { get; set; }
        public decimal? V6190 { get; set; }
        public decimal? V91120 { get; set; }
        public decimal? V121150 { get; set; }
        public decimal? V151180 { get; set; }
        public decimal? V180 { get; set; }
        public decimal? V0190 { get; set; }
        public decimal? V91m { get; set; }
        public decimal LimiteCredito { get; set; }
        public short IdTiopoMercadp { get; set; }
        public string TipoMercado { get; set; }
        public int Sector { get; set; }
        public string Descripcion { get; set; }
        public int Obetivobono { get; set; }
    }
}
