using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxexistenciaconsumiblesdefault
    {
        public int Almacen { get; set; }
        public int Codigo { get; set; }
        public decimal? Existencia { get; set; }
        public bool Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
