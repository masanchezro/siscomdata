using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinauts03
    {
        public long IdAut { get; set; }
        public long IdConsecutivoMov { get; set; }
        public int SucEnvia { get; set; }
        public int SucRecibe { get; set; }
        public string Clave { get; set; }
        public string Token { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
