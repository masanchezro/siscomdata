using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcooxequiposyeRespaldo
    {
        public short Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public short Ruta { get; set; }
        public short Turno { get; set; }
        public short Unidad { get; set; }
        public int? Operardor { get; set; }
        public string Estatus { get; set; }
        public string ObservacionesSal { get; set; }
        public string ObservacionesEnt { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
