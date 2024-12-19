using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxproducto
    {
        public int Codigo { get; set; }
        public int CodigoRenta { get; set; }
        public int ServicioNuevo { get; set; }
        public int Recargas { get; set; }
        public short DiasRenta { get; set; }
        public string Comision { get; set; }
        public short? EnvCont { get; set; }
        public string Descripcion { get; set; }
        public int? IdFamilia { get; set; }
        public string Familia { get; set; }
    }
}
