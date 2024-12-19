using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoindetalleemb
    {
        public short? Ruta { get; set; }
        public DateTime FechaPedido { get; set; }
        public int? Cilindros { get; set; }
        public int Codigo { get; set; }
        public string DesCodigo { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? Volumen { get; set; }
        public string DesUm { get; set; }
    }
}
