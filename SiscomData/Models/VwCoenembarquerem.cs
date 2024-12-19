using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenembarquerem
    {
        public int? FolioEmbarque { get; set; }
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int SucDestino { get; set; }
        public string NombreSucDestino { get; set; }
        public string EntidadFederativa { get; set; }
        public DateTime FechaRemision { get; set; }
        public string Tipo { get; set; }
        public string TipoRemision { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Canje { get; set; }
        public int? Llenado { get; set; }
        public int? Mtto { get; set; }
        public int? Analisis { get; set; }
        public int? Piloto { get; set; }
        public int? Nc { get; set; }
        public int? Otros { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
