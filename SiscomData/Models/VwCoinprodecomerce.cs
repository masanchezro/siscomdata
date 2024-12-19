using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinprodecomerce
    {
        public int Sku { get; set; }
        public string Nombre { get; set; }
        public decimal? PrecioMostrador { get; set; }
        public string Unidad { get; set; }
        public string Categoria { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public string Descripcion3 { get; set; }
        public string Descripcion4 { get; set; }
        public string Descripcion5 { get; set; }
        public string Descripcion6 { get; set; }
        public string Descripcion7 { get; set; }
        public int TipoProd { get; set; }
        public decimal? Existencia { get; set; }
    }
}
