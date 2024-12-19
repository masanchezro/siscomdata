using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinmovscodseries
    {
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public long IdConsecutivoMovSerie { get; set; }
        public string NoSerie { get; set; }

        public virtual Tdcoinmovscod IdConsecutivoMovCodNavigation { get; set; }
        public virtual Thcoinmov1 IdConsecutivoMovNavigation { get; set; }
    }
}
