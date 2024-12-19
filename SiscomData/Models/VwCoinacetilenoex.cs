using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinacetilenoex
    {
        public short LineaVta { get; set; }
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Disponible { get; set; }
        public decimal Capacidad { get; set; }
        public decimal? Cilindros { get; set; }
    }
}
