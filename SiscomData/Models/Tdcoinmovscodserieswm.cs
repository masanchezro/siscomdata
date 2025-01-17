﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoinmovscodserieswm
    {
        public long IdConsecutivoMov { get; set; }
        public long IdConsecutivoMovCod { get; set; }
        public long IdConsecutivoMovSerie { get; set; }
        public string NoSerie { get; set; }

        public virtual Tdcoinmovscodwm IdConsecutivoMovCodNavigation { get; set; }
        public virtual Thcoinmovswm IdConsecutivoMovNavigation { get; set; }
    }
}
