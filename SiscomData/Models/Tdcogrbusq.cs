using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcogrbusq
    {
        public int IdRestriccion { get; set; }
        public int Modulo { get; set; }
        public string Descripcion { get; set; }
        public string Campos { get; set; }
        public string CamposOrden { get; set; }
    }
}
