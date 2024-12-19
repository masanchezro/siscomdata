using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpedidosruteo
    {
        public short Sucursal { get; set; }
        public int? Ruta { get; set; }
        public string Servicio { get; set; }
        public string TipoCliente { get; set; }
        public string NombreCte { get; set; }
        public int Pedido { get; set; }
        public int? Recetas { get; set; }
        public string Prioridadservicio { get; set; }
        public DateTime? FechaRuteo { get; set; }
    }
}
