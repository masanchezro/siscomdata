using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadescala
    {
        public int Sucursal { get; set; }
        public int ClienteInfra { get; set; }
        public int Codigo { get; set; }
        public decimal? TopeEscala { get; set; }
        public decimal? Precio { get; set; }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tmadcodigosescala Tmadcodigosescala { get; set; }
    }
}
