using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxequiposinserie
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
    }
}
