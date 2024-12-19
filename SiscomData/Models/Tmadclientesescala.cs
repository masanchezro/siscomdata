using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadclientesescala
    {
        public int Id { get; set; }
        public int? ClienteInfra { get; set; }
        public int? CodigoInfra { get; set; }
        public int? ClienteExterno { get; set; }
        public int? CodigoExterno { get; set; }
        public decimal? Factor { get; set; }
        public decimal? Consumo { get; set; }
        public decimal? Precio { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public decimal? CantConsumida { get; set; }
        public decimal? Acumulado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
