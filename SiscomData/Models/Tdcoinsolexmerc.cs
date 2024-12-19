using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinsolexmerc
    {
        public short TipoPedido { get; set; }
        public int FolioPedido { get; set; }
        public int Sucursal { get; set; }
        public int Codigo { get; set; }
        public int? Proveedor { get; set; }
        public decimal? Maximo { get; set; }
        public decimal? Cantidad { get; set; }
        public int Partida { get; set; }
        public DateTime? FechaPedido { get; set; }
        public decimal? CantidadSolicitada { get; set; }
        public int? Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Observaciones { get; set; }
        public bool EsUrbana { get; set; }
        public int? SolicitarA { get; set; }
        public bool? Autorizada { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
