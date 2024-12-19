using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcooxfolreceta
    {
        public int IdFolioRecetas { get; set; }
        public int IdCapRecetas { get; set; }
        public int Cliente { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int Folio { get; set; }
        public string TipoCaptura { get; set; }
        public bool Cancelado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tdcooxcapreceta IdCapRecetasNavigation { get; set; }
    }
}
