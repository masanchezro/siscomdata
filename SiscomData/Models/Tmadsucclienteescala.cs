using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmadsucclienteescala
    {
        public Tmadsucclienteescala()
        {
            Tmadcodigosescalas = new HashSet<Tmadcodigosescala>();
        }

        public int Sucursal { get; set; }
        public int ClienteInfra { get; set; }
        public int? ClienteExterno { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? Factura { get; set; }
        public string Moneda { get; set; }

        public virtual ICollection<Tmadcodigosescala> Tmadcodigosescalas { get; set; }
    }
}
