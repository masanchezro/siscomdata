using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxresidentifica
    {
        public int IdIdentifica { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? SucursalDestino { get; set; }
        public string Accion { get; set; }
        public int? IdRespuesta { get; set; }
        public string DescripcionRes { get; set; }
    }
}
