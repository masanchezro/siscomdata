using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCointransito
    {
        public short Almacen { get; set; }
        public string NomAlm { get; set; }
        public int Codigo { get; set; }
        public int? Folio { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public decimal? CantidadTraspaso { get; set; }
        public string FacturaRemision { get; set; }
        public int? Pedido { get; set; }
        public int ClienteSuc { get; set; }
        public string NomCteSuc { get; set; }
        public int FolioEntrada { get; set; }
        public decimal? CantidadEntrada { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public string Transmision { get; set; }
        public int TipoProd { get; set; }
        public int EsOxidom { get; set; }
        public string NoSerie { get; set; }
        public string NumPedimento { get; set; }
        public string FolioCodeBar { get; set; }
        public string FolioQr { get; set; }
    }
}
