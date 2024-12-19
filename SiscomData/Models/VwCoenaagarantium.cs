using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenaagarantium
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Recibo { get; set; }
        public DateTime FechaMov { get; set; }
        public string Movimiento { get; set; }
        public short? Envases { get; set; }
        public decimal? Importe { get; set; }
        public string Usuario { get; set; }
        public short NumFamilia { get; set; }
        public string Familia { get; set; }
    }
}
