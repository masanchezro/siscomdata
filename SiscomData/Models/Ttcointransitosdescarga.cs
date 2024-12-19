using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcointransitosdescarga
    {
        public short Almacen { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int ClienteSuc { get; set; }
        public DateTime? FechaMov { get; set; }
        public int Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public decimal CantidadEntrada { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string NoSerie { get; set; }
        public string Usuario { get; set; }
        public string FolioCodeBar { get; set; }
        public string FolioQr { get; set; }
        public int Procesado { get; set; }
        public decimal? EmpaqueSuc { get; set; }
    }
}
