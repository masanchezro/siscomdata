using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Templeado
    {
        public int TeId { get; set; }
        public string TeApaterno { get; set; }
        public string TeAmaterno { get; set; }
        public string TeNombre { get; set; }
        public bool? TeActivo { get; set; }
        public string TeNick { get; set; }
        public string TePassword { get; set; }
        public DateTime? TeFechaIng { get; set; }
        public DateTime? TeFechaVto { get; set; }
        public string TsuId { get; set; }
        public string TeExt { get; set; }
        public string TeCelular { get; set; }
        public string TeEmail { get; set; }
        public DateTime? TeFechaBaja { get; set; }
        public bool? TeEqMovil { get; set; }
        public bool? TeEqComputo { get; set; }
        public string TeTelefono { get; set; }
        public int? TeIdPuesto { get; set; }
        public string TePreguntaSecreta { get; set; }
        public string TeRespuestaSecreta { get; set; }
    }
}
