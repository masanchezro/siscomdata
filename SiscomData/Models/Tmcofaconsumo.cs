using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcofaconsumo
    {
        public Tmcofaconsumo()
        {
            Tdcofaconsumos = new HashSet<Tdcofaconsumo>();
        }

        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaConsumo { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tdcofaconsumo> Tdcofaconsumos { get; set; }
    }
}
