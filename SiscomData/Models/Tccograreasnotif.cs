﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccograreasnotif
    {
        public Tccograreasnotif()
        {
            Trcograreascorreonotifs = new HashSet<Trcograreascorreonotif>();
        }

        public int IdProcesoArea { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Trcograreascorreonotif> Trcograreascorreonotifs { get; set; }
    }
}
