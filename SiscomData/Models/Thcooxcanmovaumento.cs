using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxcanmovaumento
    {
        public int CanMovAumentoId { get; set; }
        public int Sucursal { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Cliente { get; set; }
        public bool? Cancelado { get; set; }
        public int? ReciboI07 { get; set; }
        public DateTime? FechaMovI07 { get; set; }
        public int? ReciboO01 { get; set; }
        public DateTime? FechaMovO01 { get; set; }
        public int Codigo { get; set; }
        public int Contrato { get; set; }
        public bool Error { get; set; }
        public string Msg { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
