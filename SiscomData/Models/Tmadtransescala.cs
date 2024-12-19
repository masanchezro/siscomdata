using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadtransescala
    {
        public int IdTransEscala { get; set; }
        public int? Sucursal { get; set; }
        public string Remision { get; set; }
        public DateTime? Fecha { get; set; }
        public int? NoCliente { get; set; }
        public int? NoClienteInfra { get; set; }
        public int? Codigo { get; set; }
        public string CodigoProv { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? CantidadFac { get; set; }
        public decimal? CantidadFacProv { get; set; }
        public string Factura { get; set; }
        public string Pedido { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string UsuarioAudit { get; set; }
        public string FolioFac { get; set; }
        public DateTime? FechaFac { get; set; }
        public string UsuarioFac { get; set; }
        public decimal? Factor { get; set; }
        public int? Posicion { get; set; }
        public string Serie { get; set; }
        public string Estatus { get; set; }
    }
}
