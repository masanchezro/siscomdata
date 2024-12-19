using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctcred
    {
        public Tmcoctcred()
        {
            Tmcoctcredlcs = new HashSet<Tmcoctcredlc>();
        }

        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public decimal LimiteCredito { get; set; }
        public short Plazo { get; set; }
        public short? PlazoSuspendido { get; set; }
        public string DiaRevision { get; set; }
        public string DiaCobro { get; set; }
        public short ZonaCobro { get; set; }
        public short? ZonaRevision { get; set; }
        public decimal? Saldo { get; set; }
        public short? SucQueCobra { get; set; }
        public bool? Suspendido { get; set; }
        public string MotivoSuspension { get; set; }
        public short TipoMercado { get; set; }
        public bool EnviarSvburo { get; set; }
        public bool PagoTransfer { get; set; }
        public bool ProgramarRevision { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public decimal? AmpliacionLimiteCredito { get; set; }
        public string HorarioRevision { get; set; }
        public string HorarioCobro { get; set; }
        public string IdentificadorMercado { get; set; }

        public virtual Tccocatmerc TipoMercadoNavigation { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
        public virtual Thcocasusp Thcocasusp { get; set; }
        public virtual ICollection<Tmcoctcredlc> Tmcoctcredlcs { get; set; }
    }
}
