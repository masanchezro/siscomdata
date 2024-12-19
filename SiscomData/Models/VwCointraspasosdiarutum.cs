using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCointraspasosdiarutum
    {
        public short Ruta { get; set; }
        public DateTime? FechaMov { get; set; }
        public int? Cilindros { get; set; }
        public short LineaAgrupa { get; set; }
        public string Descripcion { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? PesoNeto { get; set; }
        public decimal? Volumen { get; set; }
        public string DesUm { get; set; }
    }
}
