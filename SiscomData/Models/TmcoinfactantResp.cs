using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcoinfactantResp
    {
        public short Almacen { get; set; }
        public string TipoMovimiento { get; set; }
        public int Factura { get; set; }
        public int Folio { get; set; }
        public int NotaCredito { get; set; }
        public int NotaCargo { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Cantidad { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
