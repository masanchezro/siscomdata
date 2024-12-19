using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Bdakm02
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string Numint { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int? CodPos { get; set; }
    }
}
