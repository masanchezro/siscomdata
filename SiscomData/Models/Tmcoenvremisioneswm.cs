using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoenvremisioneswm
    {
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public short Almacen { get; set; }
        public int Remision { get; set; }
        public DateTime FechaRemision { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string TipoOrigen { get; set; }
        public short? Movimiento { get; set; }
        public decimal? Capacidad { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string Serie { get; set; }
        public bool InformaEnsayo { get; set; }
        public bool LlenoVacio { get; set; }
        public string Valvula { get; set; }
        public string Observaciones { get; set; }
        public int Status { get; set; }
        public string EstatusMto { get; set; }
        public string MttoRecibi { get; set; }
        public string MttoLibere { get; set; }
        public DateTime? AreaFechaRecepcion { get; set; }
        public DateTime? AreaFechaLiberacion { get; set; }
        public DateTime? AreaFechaRecepcion1 { get; set; }
        public DateTime? AreaFechaLibere1 { get; set; }
        public int? CantidadEnviar { get; set; }
        public int FolioCabecera { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public int? FolioTraspaso { get; set; }
        public int SucOrigen { get; set; }
        public bool Transmitir { get; set; }
        public int? FolioEntrada { get; set; }
        public bool Particular { get; set; }
        public int SucDestino { get; set; }
        public int? FolioEmbarque { get; set; }
        public string Nodo1 { get; set; }
        public string Nodo2 { get; set; }
        public string Nodo3 { get; set; }
        public string Nodo4 { get; set; }
        public short? Area { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string TipoPar { get; set; }
        public int? RemisionPar { get; set; }
        public int? ClientePar { get; set; }
    }
}
