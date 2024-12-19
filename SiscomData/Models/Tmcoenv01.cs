using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoenv01
    {
        public Tmcoenv01()
        {
            Tdcoendemoras = new HashSet<Tdcoendemora>();
            Tdcoeninventarios = new HashSet<Tdcoeninventario>();
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
        }

        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public short? EnvProv { get; set; }
        public decimal? Deposito { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tccogrsuc SucursalNavigation { get; set; }
        public virtual ICollection<Tdcoendemora> Tdcoendemoras { get; set; }
        public virtual ICollection<Tdcoeninventario> Tdcoeninventarios { get; set; }
        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
    }
}
