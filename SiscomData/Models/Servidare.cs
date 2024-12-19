using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Servidare
    {
        public int? Servicio { get; set; }
        public int? NumCliente { get; set; }
        public string Cliente { get; set; }
        public int? NumNomina { get; set; }
        public string Operador { get; set; }
        public string TipoServicio { get; set; }
        public string Estatus { get; set; }
        public string MotivoCancelado { get; set; }
        public string Fecha { get; set; }
    }
}
