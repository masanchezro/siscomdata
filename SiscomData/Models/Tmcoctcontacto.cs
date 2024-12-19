using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctcontacto
    {
        public int Contacto { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
