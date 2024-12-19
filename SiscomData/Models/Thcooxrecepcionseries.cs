using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxrecepcionseries
    {
        public long Id { get; set; }
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int Chofer { get; set; }
        public string Estatus { get; set; }
        public string DetalleSerie { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string Origen { get; set; }
    }
}
