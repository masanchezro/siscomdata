using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoctdepurado
    {
        public int Id { get; set; }
        public short? Sucursal { get; set; }
        public int? Cliente { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Codpos { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaDepuracion { get; set; }
        public string TipoCliente { get; set; }
    }
}
