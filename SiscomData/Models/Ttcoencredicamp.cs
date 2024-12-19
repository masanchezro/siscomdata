using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoencredicamp
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public int FolioFactura { get; set; }
        public int Codigo { get; set; }
        public string CondicionPago { get; set; }
        public decimal? Importe { get; set; }
        public bool? Pagada { get; set; }
        public short SucOrigen { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Cilindros { get; set; }
    }
}
