using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxcobrotc
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Banco { get; set; }
        public string NoTarjeta { get; set; }
        public string Titular { get; set; }
        public string DigVerificador { get; set; }
        public string Vigencia { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? NoCobrar { get; set; }
    }
}
