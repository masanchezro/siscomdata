using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenconfimacorpo
    {
        public short Sucursal { get; set; }
        public int Recibo { get; set; }
        public string Mov { get; set; }
        public string Movimiento { get; set; }
        public string MovCorpo { get; set; }
        public int? Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? Envases { get; set; }
        public DateTime FechaMov { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaUltimaAct { get; set; }
        public bool? Activo { get; set; }
    }
}
