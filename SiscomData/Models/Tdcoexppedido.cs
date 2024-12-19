using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoexppedido
    {
        public int Folio { get; set; }
        public int Pedido { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tmcoexppedido FolioNavigation { get; set; }
    }
}
