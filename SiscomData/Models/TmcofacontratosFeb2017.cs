using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcofacontratosFeb2017
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string Contrato { get; set; }
        public int Partida { get; set; }
        public DateTime? FechaInicioContrato { get; set; }
        public DateTime? FechaFinContrato { get; set; }
        public decimal? MontoContrato { get; set; }
        public decimal? Facturado { get; set; }
        public int Codigo { get; set; }
        public int? UnidadContratoCodigo { get; set; }
        public int? CantidadContratoCodigo { get; set; }
        public decimal? ImporteContratoCodigo { get; set; }
        public int? UnidadCodigo { get; set; }
        public int? CantidadCodigo { get; set; }
        public decimal? ImporteCodigo { get; set; }
        public bool? Estatus { get; set; }
        public string Solicito { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string Afianzadora { get; set; }
        public string Alias { get; set; }
        public string NombreAfianzadora { get; set; }
    }
}
