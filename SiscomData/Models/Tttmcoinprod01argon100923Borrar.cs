using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tttmcoinprod01argon100923Borrar
    {
        public int? Suc { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short LineaVta { get; set; }
        public short LineaAgrupa { get; set; }
        public decimal Precio { get; set; }
        public decimal? Precioant { get; set; }
        public DateTime? Fechacambioprecio { get; set; }
        public string Usuario { get; set; }
        public DateTime Fechaaudit { get; set; }
        public decimal? Porc { get; set; }
        public decimal PrecioNvo { get; set; }
        public decimal? PrecioAntNvo { get; set; }
        public DateTime? FechacambioprecioNvo { get; set; }
        public string UsuarioNvo { get; set; }
        public DateTime FechaauditNvo { get; set; }
    }
}
