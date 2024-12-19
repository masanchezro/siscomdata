using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcortchofer
    {
        public short Sucursal { get; set; }
        public string Tipo { get; set; }
        public int Nomina { get; set; }
        public string NombreEmp { get; set; }
        public short? Ruta { get; set; }
    }
}
