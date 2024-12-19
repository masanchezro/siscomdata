using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenprov
    {
        public int Sucursal { get; set; }
        public short? Ejecutivo { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Recibo { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaMov { get; set; }
        public DateTime? FechaOrgVig { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public short? Envases { get; set; }
        public short? Devoluciones { get; set; }
        public short? Saldo { get; set; }
        public int? DiasVigencia { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
