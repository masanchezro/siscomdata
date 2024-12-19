using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoenpagare
    {
        public int NoPagare { get; set; }
        public short? Sucursal { get; set; }
        public int? Cliente { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Aval { get; set; }
        public string DomicilioA { get; set; }
        public decimal? Importe { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
