using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Obcfkm07RentaComercio
    {
        public short Almacen { get; set; }
        public int Codigo { get; set; }
        public DateTime Fechamov { get; set; }
        public string Tm { get; set; }
        public int Folio { get; set; }
        public int Notacredito { get; set; }
        public int? Cilindros { get; set; }
        public float? Cantidad { get; set; }
        public int Cliente { get; set; }
        public float? Importe { get; set; }
        public float? Importeiva { get; set; }
        public int Procesado { get; set; }
        public DateTime FechaProceso { get; set; }
    }
}
