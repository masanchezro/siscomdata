using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedfacelectmp
    {
        public int Sucursal { get; set; }
        public int Provedor { get; set; }
        public int Pedido { get; set; }
        public string Factura { get; set; }
        public int Codigo { get; set; }
        public int? CodigoElec { get; set; }
        public decimal? CantSolicitada { get; set; }
        public decimal? CantSurtida { get; set; }
        public string Moneda { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Total { get; set; }
        public DateTime Fecha { get; set; }
        public string Status { get; set; }
    }
}
