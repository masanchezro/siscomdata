using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxserviciostipoorigen
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public int Sucursal { get; set; }
        public int Pedido { get; set; }
        public int IdTipoOrigen { get; set; }
        public int TipoServicio { get; set; }
        public int IdClienteOx { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Tccooxtiposorigen IdTipoOrigenNavigation { get; set; }
    }
}
