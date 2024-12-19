using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoinpedga
    {
        public short Suc { get; set; }
        public string TipoPedido { get; set; }
        public int Codigo { get; set; }
        public int Envases { get; set; }
        public int PedidoCalculo { get; set; }
        public int PedidoModificado { get; set; }
        public int DotPatios { get; set; }
        public int DotIdeal { get; set; }
        public int DotMaxima { get; set; }
        public string Observaciones { get; set; }
        public bool DtoIe { get; set; }
        public bool DtoGc { get; set; }
        public short Ccnodo { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
