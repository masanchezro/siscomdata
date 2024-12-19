using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxkit
    {
        public int IdKit { get; set; }
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public bool Cobrar { get; set; }
    }
}
