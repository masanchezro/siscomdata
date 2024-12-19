using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpedidosfacturado
    {
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Folio { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tipopago { get; set; }
        public decimal? Totalporcodigo { get; set; }
        public string Observaciones { get; set; }
        public int? Dia { get; set; }
        public int? Mes { get; set; }
        public int? Anio { get; set; }
        public DateTime? FechaFe { get; set; }
        public string Usuario { get; set; }
    }
}
