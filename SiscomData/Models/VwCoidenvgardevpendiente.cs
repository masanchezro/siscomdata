using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidenvgardevpendiente
    {
        public int Recibo { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Garantia { get; set; }
        public decimal? Actualizacion { get; set; }
        public decimal? Devolucion { get; set; }
        public decimal? Cancelacion { get; set; }
        public string TransferenciaPendiente { get; set; }
        public string Usuario { get; set; }
    }
}
