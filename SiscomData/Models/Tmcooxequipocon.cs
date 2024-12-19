using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxequipocon
    {
        public short Sucursal { get; set; }
        public int CodigoEquipo { get; set; }
        public int CodigoConsumible { get; set; }
        public int? CantidadEquipo { get; set; }
        public int? CantidadConsumible { get; set; }
        public string Automatico { get; set; }
        public bool? Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
