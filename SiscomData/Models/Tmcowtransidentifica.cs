using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcowtransidentifica
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public string Servicio { get; set; }
        public short MaxIntentos { get; set; }
        public string PreSpname { get; set; }
        public string PostSpname { get; set; }
        public string TipoCiclo { get; set; }
        public DateTime? FultSync { get; set; }
        public bool? Active { get; set; }

        public virtual Tmcooxwservice ServicioNavigation { get; set; }
    }
}
