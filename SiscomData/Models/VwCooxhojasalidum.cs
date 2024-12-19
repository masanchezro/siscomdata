using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxhojasalidum
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int? ServicioNuevo { get; set; }
        public int? Aumentos { get; set; }
        public int? Cancelaciones { get; set; }
        public int? Recargas { get; set; }
        public string PrioridadServicio { get; set; }
    }
}
