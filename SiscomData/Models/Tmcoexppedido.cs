using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoexppedido
    {
        public Tmcoexppedido()
        {
            Tdcoexppedidos = new HashSet<Tdcoexppedido>();
        }

        public int Folio { get; set; }
        public decimal TipoCambio { get; set; }
        public string Marcas { get; set; }
        public string Notas { get; set; }
        public string TiempoEntrega { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tdcoexppedido> Tdcoexppedidos { get; set; }
    }
}
