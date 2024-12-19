using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocactasuniversale
    {
        public int IdCtaUniv { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public string Cuenta { get; set; }
        public bool Compartido { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool? Transmitir { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
