using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinayb
    {
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public string TipoMovimiento { get; set; }
        public int CteSucProv { get; set; }
        public string Documento { get; set; }
        public decimal Cantidad { get; set; }
        public int Folio { get; set; }
        public string Descripcion { get; set; }
        public string Um { get; set; }
        public string NombreSuc { get; set; }
        public DateTime FechaAudit { get; set; }
        public string NombreMov { get; set; }
        public short LineaVta { get; set; }
    }
}
