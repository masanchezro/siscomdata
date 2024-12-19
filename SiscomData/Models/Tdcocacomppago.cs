using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcocacomppago
    {
        public string Uuid { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public string SerieDocto { get; set; }
        public int? FolioDocto { get; set; }
        public string MonedaDr { get; set; }
        public decimal? TipoCambioDr { get; set; }
        public string MetodoPagoDr { get; set; }
        public short? NumParcialidad { get; set; }
        public decimal? ImpSaldoAnt { get; set; }
        public decimal? ImpPagado { get; set; }
        public decimal? ImpSaldoSoluto { get; set; }
        public string TraImpuesto { get; set; }
        public short? TraTipoFactor { get; set; }
        public decimal TraTasa { get; set; }
        public decimal? TraImporte { get; set; }
        public decimal? RetImpuesto { get; set; }
        public short? RetTipoFactor { get; set; }
        public decimal? RetTasa { get; set; }
        public decimal? RetImporte { get; set; }
        public string TraTipoFactorV4 { get; set; }
        public string RetTipoFactorV4 { get; set; }
        public string RetImpuestoV4 { get; set; }
        public decimal? RetBase { get; set; }
        public decimal? TraBase { get; set; }

        public virtual Tmcocacomppago Tmcocacomppago { get; set; }
    }
}
