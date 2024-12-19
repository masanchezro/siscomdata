using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidenvdevgar
    {
        public int Recibo { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal? Garantia { get; set; }
        public decimal? Actualizacion { get; set; }
        public decimal? Devolucion { get; set; }
        public decimal? Cancelacion { get; set; }
        public int? ReciboDevolucion { get; set; }
        public string TipoPago { get; set; }
        public string NumCheque { get; set; }
    }
}
