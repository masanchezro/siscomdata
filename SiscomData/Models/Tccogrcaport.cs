using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrcaport
    {
        public int Id { get; set; }
        public decimal Version { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
        public bool EsCabecera { get; set; }
        public string Prefijo { get; set; }
        public string Etiqueta { get; set; }
    }
}
