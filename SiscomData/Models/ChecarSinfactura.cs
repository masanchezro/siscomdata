using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class ChecarSinfactura
    {
        public string TipoCte { get; set; }
        public int Factura { get; set; }
        public string TipoC { get; set; }
        public int Pedido { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string ExcentoRecarga { get; set; }
        public string Usuario { get; set; }
    }
}
