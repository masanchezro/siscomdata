using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofadetallepredial
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string CtaPredial { get; set; }

        public virtual Tdcofadetalle Tdcofadetalle { get; set; }
        public virtual Tmcofamtro Tmcofamtro { get; set; }
    }
}
