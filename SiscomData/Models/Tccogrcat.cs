using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrcat
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Partida { get; set; }
        public string Catalogo { get; set; }
        public string Valor { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
