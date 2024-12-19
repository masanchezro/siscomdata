using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Baakm02
    {
        public short Suc { get; set; }
        public int NumEmp { get; set; }
        public string Nombre { get; set; }
        public string TipoNom { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string ColumnaMarp { get; set; }
        public string ColumnaMarp2 { get; set; }
    }
}
