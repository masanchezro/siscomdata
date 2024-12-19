using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccointenv
    {
        public Tccointenv()
        {
            InverseClaseEnvaseNavigation = new HashSet<Tccointenv>();
            Tmcoinprod01s = new HashSet<Tmcoinprod01>();
        }

        public int IdTipoEnvase { get; set; }
        public string TipoEnvase { get; set; }
        public string Descripcion { get; set; }
        public int ClaseEnvase { get; set; }
        public decimal? Deposito { get; set; }
        public decimal? DepositoCamp { get; set; }

        public virtual Tccointenv ClaseEnvaseNavigation { get; set; }
        public virtual ICollection<Tccointenv> InverseClaseEnvaseNavigation { get; set; }
        public virtual ICollection<Tmcoinprod01> Tmcoinprod01s { get; set; }
    }
}
