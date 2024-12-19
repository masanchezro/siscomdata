using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxrepvisimp2
    {
        public int Id { get; set; }
        public int IdHistorial { get; set; }
        public int Cliente { get; set; }
        public int Ruta { get; set; }
        public string SucursalImprimio { get; set; }
        public DateTime FechaImpresion { get; set; }
    }
}
