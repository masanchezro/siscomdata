using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Obcfkm07Facturado
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? Fechaultrenta { get; set; }
        public int? Codigoenvases { get; set; }
        public string Usuario { get; set; }
        public int? Foliofactura { get; set; }
        public int? Almacen { get; set; }
        public string Tm { get; set; }
        public int Codigofact { get; set; }
        public DateTime Fechamov { get; set; }
        public int Folio { get; set; }
        public int? Notacredito { get; set; }
        public float? Cantidad { get; set; }
        public int Ctefact { get; set; }
        public float? Importe { get; set; }
        public DateTime? Fechaproceso { get; set; }
    }
}
