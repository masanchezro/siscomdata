using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TdcooxpagincentivosAnt
    {
        public DateTime Fecha { get; set; }
        public int Unidad { get; set; }
        public int Nomina { get; set; }
        public string Nombre { get; set; }
        public int Cliente { get; set; }
        public int Pedido { get; set; }
        public string PrioridadServicio { get; set; }
        public int? TipoServicio { get; set; }
        public string Turno { get; set; }
        public int? Codigo { get; set; }
    }
}
