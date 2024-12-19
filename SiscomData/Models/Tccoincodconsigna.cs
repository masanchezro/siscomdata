using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoincodconsigna
    {
        public int Sucursal { get; set; }
        public int Codigo { get; set; }
        public string PlanEntrega { get; set; }
        public string Centro { get; set; }
        public string Proveedor { get; set; }
        public string NombreProv { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
