using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccortgrupoalmrutum
    {
        public int Grupo { get; set; }
        public int Almacen { get; set; }
        public int? Defaul { get; set; }
        public string SchemaDb { get; set; }
        public string Dbnombre { get; set; }
    }
}
