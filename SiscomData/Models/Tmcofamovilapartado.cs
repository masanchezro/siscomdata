using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofamovilapartado
    {
        public int Sucursal { get; set; }
        public int? Folio { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? Consecutivo { get; set; }
        public decimal Apartada { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
