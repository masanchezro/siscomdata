using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinnuloconsumo
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short LineaVta { get; set; }
        public DateTime FechaAlta { get; set; }
        public decimal Existencia { get; set; }
        public decimal? Maximo { get; set; }
        public DateTime? FecUltCon { get; set; }
        public int? Dias { get; set; }
        public string NombreSuc { get; set; }
        public string Clasificacion { get; set; }
        public string Tipoconsumo { get; set; }
    }
}
