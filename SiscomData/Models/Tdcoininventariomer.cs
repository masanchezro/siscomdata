using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoininventariomer
    {
        public short Sucursal { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Scantidad { get; set; }
        public decimal? Fcantidad { get; set; }
        public decimal? Diferencia { get; set; }
        public string Aclaraciones { get; set; }
        public short? Linea { get; set; }
        public bool Validar { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public decimal? PrecioMostrador { get; set; }
        public bool? Transmitir { get; set; }
        public string TipoMer { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
