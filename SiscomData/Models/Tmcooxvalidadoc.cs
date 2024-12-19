using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxvalidadoc
    {
        public int IdvalidaDoc { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public bool CompDomPac { get; set; }
        public bool IdentifPac { get; set; }
        public bool CompDomFam { get; set; }
        public bool IdentFam { get; set; }
        public bool ContratoOxidom { get; set; }
        public bool Pagare { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
