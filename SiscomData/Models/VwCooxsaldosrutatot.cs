using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxsaldosrutatot
    {
        public short Ruta { get; set; }
        public string NombreRuta { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Clasificacion { get; set; }
        public decimal? Saldo { get; set; }
    }
}
