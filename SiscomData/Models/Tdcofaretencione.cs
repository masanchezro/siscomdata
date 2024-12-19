using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofaretencione
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string IdRetencion { get; set; }
        public int Codigo { get; set; }
        public bool? AplicaIva { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Monto { get; set; }

        public virtual Tmcofamtro Tmcofamtro { get; set; }
    }
}
