using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoidoperacione
    {
        public short? Sucursal { get; set; }
        public DateTime? Fecha { get; set; }
        public short? Area { get; set; }
        public short? Linea { get; set; }
        public short? Columna { get; set; }
        public string Valor { get; set; }
        public string Tipo { get; set; }
    }
}
