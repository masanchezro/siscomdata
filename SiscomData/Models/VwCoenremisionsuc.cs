using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenremisionsuc
    {
        public short Sucursal { get; set; }
        public int Remision { get; set; }
        public string Tipo { get; set; }
        public int Status { get; set; }
        public string Estatus { get; set; }
        public int SucOrigen { get; set; }
        public int SucDestino { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSucDestino { get; set; }
        public DateTime FechaRemision { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public int Codigo { get; set; }
        public string DesCodigo { get; set; }
        public int? Envases { get; set; }
        public decimal? Capacidad { get; set; }
        public string Serie { get; set; }
        public bool InformaEnsayo { get; set; }
        public bool LlenoVacio { get; set; }
        public string Valvula { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public int? FolioTraspaso { get; set; }
        public DateTime? AreaFechaRecepcion { get; set; }
        public DateTime? AreaFechaLiberacion { get; set; }
        public int FolioCabecera { get; set; }
        public int? FolioEntrada { get; set; }
        public bool Particular { get; set; }
        public string Usuario { get; set; }
    }
}
