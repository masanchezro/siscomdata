using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoidficha
    {
        public int IdFicha { get; set; }
        public string NoFicha { get; set; }
        public decimal ImporteDeposito { get; set; }
        public short TipoFicha { get; set; }
        public string ClaveMon { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Caja { get; set; }
        public string Asignacion { get; set; }
        public string Cuenta { get; set; }
        public string DescripcionFicha { get; set; }
        public string MetodoPago { get; set; }
        public int? Banco { get; set; }
    }
}
