using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoincteequipo
    {
        public int IdClienteEquipo { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public decimal Cantidad { get; set; }
        public string NoSerie { get; set; }
        public string Modelo { get; set; }
        public string NoActivoFijo { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime? FechaUltMov { get; set; }
        public string Usuario { get; set; }
    }
}
