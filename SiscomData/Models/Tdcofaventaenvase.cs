using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofaventaenvase
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoDocumento { get; set; }
        public int Codigo { get; set; }
        public int FolioControl { get; set; }
        public int Folio { get; set; }
        public int? DotacionVendida { get; set; }
        public DateTime? Fecha { get; set; }
        public int? TipoMovimiento { get; set; }

        public virtual Tmcofamtro Tmcofamtro { get; set; }
    }
}
