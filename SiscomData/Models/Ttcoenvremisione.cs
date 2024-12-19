using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoenvremisione
    {
        public short Almacen { get; set; }
        public int Remision { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Nodo { get; set; }
    }
}
