using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenvisitadorcam
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int? Nomina { get; set; }
        public string NombreEmp { get; set; }
        public string Usuario { get; set; }
    }
}
