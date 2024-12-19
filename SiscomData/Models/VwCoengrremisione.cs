using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoengrremisione
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public short Area { get; set; }
        public string NombreArea { get; set; }
        public int Remision { get; set; }
        public int SucOrigen { get; set; }
        public string Tipo { get; set; }
        public string NombreRem { get; set; }
        public int Estatus { get; set; }
        public string EstatusRem { get; set; }
        public DateTime FechaRemision { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public int? Antiguedad { get; set; }
        public DateTime? FechaTraspaso { get; set; }
        public int? FolioTraspaso { get; set; }
        public DateTime? AreaFechaRecepcion { get; set; }
        public DateTime? AreaFechaLiberacion { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Envases { get; set; }
        public string Observaciones { get; set; }
    }
}
