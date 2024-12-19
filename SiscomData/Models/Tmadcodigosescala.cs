using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadcodigosescala
    {
        public Tmadcodigosescala()
        {
            Tmadescalas = new HashSet<Tmadescala>();
        }

        public int Codigo { get; set; }
        public int Sucursal { get; set; }
        public int ClienteInfra { get; set; }
        public int? CodigoExterno { get; set; }
        public decimal? Factor { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tmadsucclienteescala Tmadsucclienteescala { get; set; }
        public virtual ICollection<Tmadescala> Tmadescalas { get; set; }
    }
}
