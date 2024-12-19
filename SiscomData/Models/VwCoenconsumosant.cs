using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenconsumosant
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string CteNuevo { get; set; }
        public int Codigo { get; set; }
        public short? Dotacion { get; set; }
        public short? Propiedad { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
    }
}
