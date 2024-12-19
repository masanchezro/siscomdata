using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenreminventario
    {
        public string TipoInv { get; set; }
        public short Almacen { get; set; }
        public int Remision { get; set; }
        public string FechaRemision { get; set; }
        public string FechaRecepcion { get; set; }
        public int Codigo { get; set; }
        public int? CodigoDotacion { get; set; }
        public string Tipo { get; set; }
        public int? CantidadEnviar { get; set; }
        public int SucOrigen { get; set; }
        public int SucDestino { get; set; }
        public string Estatus { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public int? FolioTraspaso { get; set; }
        public bool Particular { get; set; }
    }
}
