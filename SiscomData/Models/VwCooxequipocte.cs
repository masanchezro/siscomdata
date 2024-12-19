using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxequipocte
    {
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NoSerie { get; set; }
        public string Modelo { get; set; }
        public string NoActivoFijo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaRevision { get; set; }
    }
}
