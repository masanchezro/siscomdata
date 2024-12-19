using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxadeudorentaanticipadum
    {
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string NombreCte { get; set; }
        public int? DiasRenta { get; set; }
        public int? DiasAdeudo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaUltPago { get; set; }
        public string FlimitePago { get; set; }
        public DateTime? FechaCorte { get; set; }
        public decimal? ImpProxMes { get; set; }
        public decimal? ImpVencido { get; set; }
        public int? CantEquipo { get; set; }
        public DateTime? AltaCliente { get; set; }
        public DateTime? BajaPaciente { get; set; }
        public string Formapago { get; set; }
        public DateTime? FechaBajaEquipo { get; set; }
        public string TieneEquipo { get; set; }
        public int CodigoEnvases { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public decimal? Deposito { get; set; }
        public decimal PrecioDia { get; set; }
        public string Ejecutivo { get; set; }
    }
}
