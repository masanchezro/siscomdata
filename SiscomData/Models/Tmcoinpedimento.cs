using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinpedimento
    {
        public short Almacen { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime FechaImportacion { get; set; }
        public int Codigo { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int NumeroPartida { get; set; }
        public int? ClienteSuc { get; set; }
        public decimal? Cantidad { get; set; }
        public string Identifica { get; set; }
        public int? Pedido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
