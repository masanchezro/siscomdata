using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwMcoctgral
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string NumInt { get; set; }
        public string Colonia { get; set; }
        public string Codpos { get; set; }
        public string Telefono1 { get; set; }
        public string Email { get; set; }
        public string TipoCte { get; set; }
        public short? Ejecutivo1 { get; set; }
        public short? Ejecutivo2 { get; set; }
    }
}
