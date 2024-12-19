using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrtmon
    {
        public Tccogrtmon()
        {
            Tmcoctpreesps = new HashSet<Tmcoctpreesp>();
        }

        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public decimal? TipoDeCambio { get; set; }
        public bool? Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcoctpreesp> Tmcoctpreesps { get; set; }
    }
}
