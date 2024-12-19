using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcoinsurpedmerNoenviuarversion
    {
        public int Sucursal { get; set; }
        public int FolioPedido { get; set; }
        public int Codigo { get; set; }
        public int Partida { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantSol { get; set; }
        public decimal? CantSurt { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Usuario { get; set; }
    }
}
