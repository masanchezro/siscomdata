using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TdcooxseriessyeRespaldo
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public short Ruta { get; set; }
        public short Unidad { get; set; }
        public short Turno { get; set; }
        public short Partida { get; set; }
        public int Codigo { get; set; }
        public string Serie { get; set; }
        public short? Salida { get; set; }
        public short? Entrada { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Cliente { get; set; }
    }
}
