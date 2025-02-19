﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocapromotora
    {
        public Tmcocapromotora()
        {
            Tdcocapromotoras = new HashSet<Tdcocapromotora>();
            Trcocacobradorpromos = new HashSet<Trcocacobradorpromo>();
        }

        public int NumPromotora { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool Supervisor { get; set; }

        public virtual ICollection<Tdcocapromotora> Tdcocapromotoras { get; set; }
        public virtual ICollection<Trcocacobradorpromo> Trcocacobradorpromos { get; set; }
    }
}
