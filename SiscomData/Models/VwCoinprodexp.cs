using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinprodexp
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public int SubCodigo { get; set; }
        public int Proveedor { get; set; }
        public string Um { get; set; }
        public string Umi { get; set; }
        public decimal? CostoCompra { get; set; }
        public string DescripcionEsp { get; set; }
        public string DescripcionEng { get; set; }
        public int? MultiploEmpaque { get; set; }
        public string FraccionArancelaria { get; set; }
        public decimal? MinimaCompra { get; set; }
        public float? PFob { get; set; }
        public float? PCfr { get; set; }
        public float? PCif { get; set; }
        public float? POtros { get; set; }
        public short LineaVta { get; set; }
        public decimal Existencia { get; set; }
    }
}
