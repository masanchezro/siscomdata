using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinsurpedmer
    {
        public int Consec { get; set; }
        public int Sucursal { get; set; }
        public int FolioPedido { get; set; }
        public int Codigo { get; set; }
        public int Partida { get; set; }
        public decimal? Cantidad { get; set; }
        public int? FolioTraspaso { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Usuario { get; set; }
        public int? IdPedido { get; set; }

        public virtual Tmcoinsurpedmer Tmcoinsurpedmer { get; set; }
    }
}
