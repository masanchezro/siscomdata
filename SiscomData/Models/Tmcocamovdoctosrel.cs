using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocamovdoctosrel
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public string TipoMovimiento { get; set; }
        public string Uuid { get; set; }
        public string TipoRelacion { get; set; }
        public int? FolioRel { get; set; }
        public DateTime FechaProcesadoRel { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
