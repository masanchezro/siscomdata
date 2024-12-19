using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctgral
    {
        public Tmcoctgral()
        {
            Tccocadiasrevcobs = new HashSet<Tccocadiasrevcob>();
            Tdcoctentregas = new HashSet<Tdcoctentrega>();
            Tdcoctobservaciones = new HashSet<Tdcoctobservacione>();
            Tdcoenvmovs = new HashSet<Tdcoenvmov>();
            Tdconocomgs = new HashSet<Tdconocomg>();
            Thcoerrorfacs = new HashSet<Thcoerrorfac>();
            Tmcocamovs = new HashSet<Tmcocamov>();
            Tmcoctcuentapagos = new HashSet<Tmcoctcuentapago>();
            Tmcoctpreesps = new HashSet<Tmcoctpreesp>();
            Tmcoctrefbancos = new HashSet<Tmcoctrefbanco>();
            Tmcoctsolpreesps = new HashSet<Tmcoctsolpreesp>();
            TmcoenvcampLms = new HashSet<TmcoenvcampLm>();
            TmcoenvcampNcs = new HashSet<TmcoenvcampNc>();
            Tmcofacodprodctes = new HashSet<Tmcofacodprodcte>();
            Tmcofacontratos = new HashSet<Tmcofacontrato>();
            Tmcofarequisitos = new HashSet<Tmcofarequisito>();
        }

        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int? ClienteAnt { get; set; }
        public int? ClienteFactura { get; set; }
        public string ClienteViejo { get; set; }
        public string TipoCte { get; set; }
        public int? SubTipoCte { get; set; }
        public string TipoRetencion { get; set; }
        public string AutorizacionSat { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string NumInt { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string Codpos { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string GeoLat { get; set; }
        public string GeoLon { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string TipoFac { get; set; }
        public bool? Remisionar { get; set; }
        public bool? FactRemAut { get; set; }
        public decimal IvaCte { get; set; }
        public string CondPago { get; set; }
        public short? Giro { get; set; }
        public short? SubGiro { get; set; }
        public string GrupoCia { get; set; }
        public string CteEspecial { get; set; }
        public string ExentoRenta { get; set; }
        public string ExentoGm { get; set; }
        public string See { get; set; }
        public short? EjeGas { get; set; }
        public string TipoEjecutivoGas { get; set; }
        public short? EjeMer { get; set; }
        public short? Copias { get; set; }
        public string MedioCapto { get; set; }
        public int? NominaCapto { get; set; }
        public string SolicitadoPor { get; set; }
        public bool? EsForaneo { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public int? TipoAlta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string ClaveCliente { get; set; }
        public string Curp { get; set; }
        public string TipoReg { get; set; }
        public int? DistMercancia { get; set; }
        public string NomComercial { get; set; }
        public string CatGases { get; set; }
        public string CatMercancias { get; set; }
        public int? Activo { get; set; }

        public virtual Tccoctcondpago CondPagoNavigation { get; set; }
        public virtual Tccoctgpocium GrupoCiaNavigation { get; set; }
        public virtual Tccoctmcapto MedioCaptoNavigation { get; set; }
        public virtual Tccoctsubtct SubTipoCteNavigation { get; set; }
        public virtual Tccoctsubgiro Tccoctsubgiro { get; set; }
        public virtual Tdcoencontrato Tdcoencontrato { get; set; }
        public virtual Tccocttc TipoCteNavigation { get; set; }
        public virtual Tccocttipoejega TipoEjecutivoGasNavigation { get; set; }
        public virtual Tccofacatregfi TipoRegNavigation { get; set; }
        public virtual Tdcoctclubsoldador Tdcoctclubsoldador { get; set; }
        public virtual Tdcoenvisitadorcam Tdcoenvisitadorcam { get; set; }
        public virtual Tdcogrgtosmant Tdcogrgtosmant { get; set; }
        public virtual ThcocaexpcredGenerale ThcocaexpcredGenerale { get; set; }
        public virtual Tmcoctcred Tmcoctcred { get; set; }
        public virtual Tmcooxcliente Tmcooxcliente { get; set; }
        public virtual ICollection<Tccocadiasrevcob> Tccocadiasrevcobs { get; set; }
        public virtual ICollection<Tdcoctentrega> Tdcoctentregas { get; set; }
        public virtual ICollection<Tdcoctobservacione> Tdcoctobservaciones { get; set; }
        public virtual ICollection<Tdcoenvmov> Tdcoenvmovs { get; set; }
        public virtual ICollection<Tdconocomg> Tdconocomgs { get; set; }
        public virtual ICollection<Thcoerrorfac> Thcoerrorfacs { get; set; }
        public virtual ICollection<Tmcocamov> Tmcocamovs { get; set; }
        public virtual ICollection<Tmcoctcuentapago> Tmcoctcuentapagos { get; set; }
        public virtual ICollection<Tmcoctpreesp> Tmcoctpreesps { get; set; }
        public virtual ICollection<Tmcoctrefbanco> Tmcoctrefbancos { get; set; }
        public virtual ICollection<Tmcoctsolpreesp> Tmcoctsolpreesps { get; set; }
        public virtual ICollection<TmcoenvcampLm> TmcoenvcampLms { get; set; }
        public virtual ICollection<TmcoenvcampNc> TmcoenvcampNcs { get; set; }
        public virtual ICollection<Tmcofacodprodcte> Tmcofacodprodctes { get; set; }
        public virtual ICollection<Tmcofacontrato> Tmcofacontratos { get; set; }
        public virtual ICollection<Tmcofarequisito> Tmcofarequisitos { get; set; }
    }
}
