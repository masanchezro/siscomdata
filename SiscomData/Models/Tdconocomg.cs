using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdconocomg
    {
        public short Sucursal { get; set; }
        public short? Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Gas { get; set; }
        public int Nomina { get; set; }
        public int? Porcentaje { get; set; }
        public int? FolioFactura { get; set; }
        public int CargasInicial { get; set; }
        public decimal ValoresInicial { get; set; }
        public decimal? ComisionInicial { get; set; }
        public decimal? ComisionSubsecuente { get; set; }
        public short? SucOrigen { get; set; }
        public short? SucDestino { get; set; }
        public bool? CteNuevo { get; set; }
        public bool? Pagar { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? AplicoNotaCredito { get; set; }

        public virtual Tmcoinprod01 GasNavigation { get; set; }
        public virtual Tcconoemp Tcconoemp { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
