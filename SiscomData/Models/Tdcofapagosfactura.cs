using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcofapagosfactura
    {
        public int Folio { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoDocumento { get; set; }
        public int IdPago { get; set; }
        public string ListaPago { get; set; }
        public string DetalleTipoPago { get; set; }
        public string NoPago { get; set; }
        public int? IdBanco { get; set; }
        public decimal? Monto { get; set; }
        public string DescripcionDetalleTipoPago { get; set; }
        public string Promociones { get; set; }
        public string Referencia { get; set; }

        public virtual Tdcogrproch Tdcogrproch { get; set; }
        public virtual Tmcofamtro Tmcofamtro { get; set; }
    }
}
