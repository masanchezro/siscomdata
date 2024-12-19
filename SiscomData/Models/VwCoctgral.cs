using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoctgral
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string TipoCliente { get; set; }
        public string SubTipoCliente { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string CodigoPostal { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public decimal? IvaCliente { get; set; }
        public decimal? LimiteCredito { get; set; }
        public string CondicionesPago { get; set; }
        public string Giro { get; set; }
        public string SubGiro { get; set; }
        public string GrupoCompania { get; set; }
        public string ClienteEspecial { get; set; }
        public string ExentoRenta { get; set; }
        public string ExentoGm { get; set; }
        public string See { get; set; }
        public string EjecutivoGas { get; set; }
        public string EjecutivoMer { get; set; }
        public string MedioConcepto { get; set; }
        public string TipoEjecutivoGas { get; set; }
        public bool? EsForaneo { get; set; }
        public string NominaCapto { get; set; }
        public DateTime? FechaAlta { get; set; }
        public decimal? SaldoMensual { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public int? NumNominaCapto { get; set; }
        public int TipoAlta { get; set; }
    }
}
