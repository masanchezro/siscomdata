using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcointransitowm
    {
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public short Almacen { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int ClienteSuc { get; set; }
        public int FolioEntrada { get; set; }
        public DateTime FechaMov { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public int Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public string NoSerie { get; set; }
        public decimal? CantidadEntrada { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public string NumPedimento { get; set; }
        public string NumAduana { get; set; }
        public DateTime? FechaImportacion { get; set; }
        public string Transmision { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
