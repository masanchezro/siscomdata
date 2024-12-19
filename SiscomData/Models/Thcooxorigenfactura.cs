using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxorigenfactura
    {
        public int OriFacId { get; set; }
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public int TipoOriFacId { get; set; }
        public string TipoCliente { get; set; }
        public int? SubTipoCte { get; set; }
        public int? CteFirma { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
