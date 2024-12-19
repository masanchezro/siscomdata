using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxexistenciaconsumible
    {
        public int Operador { get; set; }
        public int Codigo { get; set; }
        public decimal Existencia { get; set; }
        public decimal ApartadoMovs { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
