using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCortconrutadiarium
    {
        public int Folio { get; set; }
        public int? Pedido { get; set; }
        public string FiltroRutas { get; set; }
        public string TipoPedido { get; set; }
        public DateTime? Fecha { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string DireccionEnt { get; set; }
        public string CodigoPostal { get; set; }
        public short Ruta { get; set; }
        public string NomRuta { get; set; }
        public int? Cilindros { get; set; }
        public string TipoPago { get; set; }
        public string Reparto { get; set; }
        public string ObservacionesPartidas { get; set; }
        public string ObservacionesPreCargadas { get; set; }
        public string Observaciones { get; set; }
    }
}
