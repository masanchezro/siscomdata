using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocaconektum
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Pedido { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public string ConektaOrd { get; set; }
        public string MetodoPago { get; set; }
        public string BancoEmisor { get; set; }
        public string NombreTc { get; set; }
        public decimal? ImpCargo { get; set; }
        public decimal? ImpComision { get; set; }
        public string NoOperacion { get; set; }
        public string CadenaPedido { get; set; }
        public string CadenaPago { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaPago { get; set; }
        public int? FolioFactura { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
