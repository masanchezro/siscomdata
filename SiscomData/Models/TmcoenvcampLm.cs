﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcoenvcampLm
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int? Dotacion { get; set; }
        public int? DotProm { get; set; }
        public int? EnvRec { get; set; }
        public int? EnvDev { get; set; }
        public int? EnvVend { get; set; }
        public int? EnvIrrec { get; set; }
        public int? EnvActCons { get; set; }
        public int? EnvLenR { get; set; }
        public int? EnvActDep { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
        public virtual Tmcoctgral Tmcoctgral { get; set; }
    }
}
