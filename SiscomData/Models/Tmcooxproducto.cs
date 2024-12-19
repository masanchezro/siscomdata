using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxproducto
    {
        public int Codigo { get; set; }
        public int CodigoRenta { get; set; }
        public int ServicioNuevo { get; set; }
        public int Recargas { get; set; }
        public short DiasRenta { get; set; }
        public string Comision { get; set; }
        public bool AgregarCilCon { get; set; }
        public int CodigoTraspaso { get; set; }
        public decimal Capacidad { get; set; }
        public int? FamiliaServicio { get; set; }
        public int? CodigoAgrupa { get; set; }
        public string RequiereFoto { get; set; }
        public decimal? ImporteDeposito { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
