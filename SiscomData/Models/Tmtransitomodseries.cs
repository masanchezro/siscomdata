using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmtransitomodseries
    {
        public int IdConsetivoMovCorr { get; set; }
        public int? Folio { get; set; }
        public int? Pedido { get; set; }
        public byte[] FacturaRemision { get; set; }
        public int? Codigo { get; set; }
        public byte[] NoSerie { get; set; }
        public byte[] NoSerieAnt { get; set; }
        public int? Origen { get; set; }
        public int? Destino { get; set; }
        public string Transmision { get; set; }
    }
}
