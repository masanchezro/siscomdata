using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinmovtrasconsumible
    {
        public DateTime FechaMov { get; set; }
        public int? Cc { get; set; }
        public string NombreSuc { get; set; }
        public string NumParte { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Total { get; set; }
        public string Observaciones { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public short Linea { get; set; }
        public string DesFam { get; set; }
    }
}
