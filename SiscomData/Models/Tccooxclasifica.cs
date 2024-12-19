using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxclasifica
    {
        public string Clasificacion { get; set; }
        public string Descripcion { get; set; }
        public bool? EquipoSerie { get; set; }
        public bool? Almacen { get; set; }
        public bool? EntregaCte { get; set; }
        public string Pedido { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
