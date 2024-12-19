using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxrecibosdev
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int ReciboDev { get; set; }
        public DateTime FechaMov { get; set; }
        public int Codigo { get; set; }
        public int? Operador { get; set; }
        public short? Turno { get; set; }
        public short? Unidad { get; set; }
        public short? Equipo { get; set; }
        public short? Ruta { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
