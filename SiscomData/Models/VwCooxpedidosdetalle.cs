using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpedidosdetalle
    {
        public int Codigo { get; set; }
        public int Cliente { get; set; }
        public string Descripcion { get; set; }
        public int Propiedad { get; set; }
        public int Contrato { get; set; }
        public int DiasRenta { get; set; }
        public DateTime? FechaUltPago { get; set; }
        public decimal ImporteConsumo { get; set; }
        public decimal ImporteRenta { get; set; }
        public decimal ImporteIva { get; set; }
        public decimal FactorIva { get; set; }
        public decimal FacRentaIva { get; set; }
        public decimal ImpRentaIva { get; set; }
        public int CodigoRenta { get; set; }
        public int Recargas { get; set; }
        public int ServicioNuevo { get; set; }
        public int Pedido { get; set; }
    }
}
