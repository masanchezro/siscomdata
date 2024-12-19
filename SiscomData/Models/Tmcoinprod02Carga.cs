using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinprod02Carga
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public decimal? MaxAnt { get; set; }
        public decimal? Maximo { get; set; }
        public decimal? Minimo { get; set; }
        public short? Factor { get; set; }
        public bool? MaximoModificado { get; set; }
        public decimal? Existencia { get; set; }
        public decimal? ApartadoFac { get; set; }
        public decimal? ApartadoSuc { get; set; }
        public decimal? Backorder { get; set; }
        public string TipoPedido { get; set; }
        public DateTime? FecUltCon { get; set; }
        public int? CcpideGas { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public decimal? ApartadoMovil { get; set; }
        public string Accion { get; set; }
    }
}
