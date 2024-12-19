using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcointransitomodseries
    {
        public int IdConsetivoMovCorr { get; set; }
        public int? Folio { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public int? Codigo { get; set; }
        public string NoSerie { get; set; }
        public string NoSerieAnt { get; set; }
        public int? Origen { get; set; }
        public int? Destino { get; set; }
        public string Transmision { get; set; }
    }
}
