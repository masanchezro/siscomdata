using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcortproforma
    {
        public short Sucursal { get; set; }
        public int Folio { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Cliente { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? TipoProd { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public string Um { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcortproforma Tmcortproforma { get; set; }
    }
}
