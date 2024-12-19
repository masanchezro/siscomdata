using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinayb
    {
        public int IdConsecutivo { get; set; }
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public string TipoMovimiento { get; set; }
        public int CteSucProv { get; set; }
        public string Documento { get; set; }
        public decimal Cantidad { get; set; }
        public int Folio { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tccogrsuc SucursalNavigation { get; set; }
    }
}
