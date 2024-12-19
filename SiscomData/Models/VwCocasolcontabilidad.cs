using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCocasolcontabilidad
    {
        public short SucursalSolicita { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int? NoDocumento { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal? Importe { get; set; }
        public string Moneda { get; set; }
        public string NombreBanco { get; set; }
        public string Referencia { get; set; }
        public int Autorizada { get; set; }
        public int Revocada { get; set; }
        public string FormaPago { get; set; }
        public DateTime? FechaDeposito { get; set; }
    }
}
