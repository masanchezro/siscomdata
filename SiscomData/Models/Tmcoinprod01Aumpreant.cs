using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinprod01Aumpreant
    {
        public string Usuario { get; set; }
        public int? Codigo { get; set; }
        public decimal? Precio { get; set; }
        public decimal? PrecioAnt { get; set; }
        public DateTime? FechaCambioPrecio { get; set; }
        public string UsuarioAudit { get; set; }
        public DateTime? FechaAudit { get; set; }
        public DateTime? FechaRespaldo { get; set; }
    }
}
