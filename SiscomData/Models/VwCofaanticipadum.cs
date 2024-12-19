using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofaanticipadum
    {
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Factura { get; set; }
        public DateTime? Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public int Folio { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantFac { get; set; }
        public decimal? NotaCredito { get; set; }
        public decimal? CantEntregada { get; set; }
        public decimal? Total { get; set; }
    }
}
