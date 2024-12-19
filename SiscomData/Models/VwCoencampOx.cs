using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencampOx
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string NombreCte { get; set; }
        public short Ejecutivo { get; set; }
        public short? NumCamp { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public decimal Deposito { get; set; }
        public int? DotTotal { get; set; }
        public short Contrato { get; set; }
        public short? Propiedad { get; set; }
        public int? OxEnvIrrec { get; set; }
        public int? OxEnvDev { get; set; }
        public int? OxEnvVend { get; set; }
        public int? OxEnvActDep { get; set; }
        public int? OxEnvActCons { get; set; }
        public int? OxEnvCambio { get; set; }
        public int? OxEnvActLr { get; set; }
    }
}
