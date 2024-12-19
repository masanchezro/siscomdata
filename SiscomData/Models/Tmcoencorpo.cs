using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoencorpo
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int ReciboCorpo { get; set; }
        public int Recibo { get; set; }
        public short? SucursalEnv { get; set; }
        public short? IdError { get; set; }
        public DateTime FechaMov { get; set; }
        public string TipoMov { get; set; }
        public short? Envases { get; set; }
        public string Observaciones { get; set; }
        public decimal? Importe { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }

        public virtual Tccoenerrorcorpo IdErrorNavigation { get; set; }
    }
}
