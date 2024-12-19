using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcointransitoserieswm
    {
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public long IdConsecutivoMovSerie { get; set; }
        public int Almacen { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int ClienteSuc { get; set; }
        public int Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public string NoSerie { get; set; }
        public string Transmision { get; set; }
        public int? Lote { get; set; }
    }
}
