using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocasolcontareserv
    {
        public int Id { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoMovimiento { get; set; }
        public string Referencia { get; set; }
        public string Usuario { get; set; }
        public int? NoDocumento { get; set; }
        public decimal? Saldo { get; set; }
    }
}
