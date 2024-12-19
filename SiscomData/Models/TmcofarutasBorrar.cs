using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcofarutasBorrar
    {
        public int Ruta { get; set; }
        public string Tipo { get; set; }
        public string DescripcionRuta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
