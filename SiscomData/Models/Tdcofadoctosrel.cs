using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofadoctosrel
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaFe { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string Uuid { get; set; }
        public string TipoRelacion { get; set; }
        public int FolioRel { get; set; }
        public DateTime FechaFerel { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
