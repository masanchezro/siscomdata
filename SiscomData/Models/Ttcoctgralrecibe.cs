using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoctgralrecibe
    {
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
    }
}
