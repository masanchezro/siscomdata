using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoenpedidose
    {
        public short Sucursal { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string NombreCte { get; set; }
        public string Giro { get; set; }
        public int? TipoProd { get; set; }
        public decimal? Capacidad { get; set; }
        public string Valvula { get; set; }
        public int? Envases { get; set; }
        public int? Patios { get; set; }
        public int? DotIdeal { get; set; }
        public int? Diferencia { get; set; }
        public int? Consumos { get; set; }
        public int? Cargas { get; set; }
        public string Observaciones { get; set; }
        public bool? Enviado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tccogrsuc SucursalNavigation { get; set; }
    }
}
