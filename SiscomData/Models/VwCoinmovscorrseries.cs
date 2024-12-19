using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinmovscorrseries
    {
        public int Folio { get; set; }
        public short Almacen { get; set; }
        public int ClienteSuc { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NoSerie { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMovimiento { get; set; }
        public int? Cantidad { get; set; }
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public long IdConsecutivoMovSerie { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
    }
}
