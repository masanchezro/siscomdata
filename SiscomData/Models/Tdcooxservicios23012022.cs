using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxservicios23012022
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public short Sucursal { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int Codigo { get; set; }
        public int DiasRenta { get; set; }
        public int Contrato { get; set; }
        public int Propiedad { get; set; }
        public decimal ImporteConsumo { get; set; }
        public decimal ImporteRenta { get; set; }
        public decimal? ImporteConsumible { get; set; }
        public int Cargas { get; set; }
        public DateTime? FechaUltPago { get; set; }
        public int? Kit { get; set; }
        public int? CantidadKit { get; set; }
        public string NoSerie { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public string ChoferSvoNvo { get; set; }
        public bool Resguardo { get; set; }
        public decimal? ImporteIva { get; set; }
        public decimal? FactorIva { get; set; }
        public decimal? ImpRentaIva { get; set; }
        public decimal? FacRentaIva { get; set; }
        public decimal? ImpConsIva { get; set; }
        public decimal? FacConsIva { get; set; }
        public int? EquiposRenta { get; set; }
        public string TipoProd { get; set; }
        public int? NominaChofer { get; set; }
        public int? CantConsFacturable { get; set; }
        public decimal? ImpDeposito { get; set; }
        public int CantNc { get; set; }
    }
}
