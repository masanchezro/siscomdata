using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoenvstatusrem
    {
        public Tccoenvstatusrem()
        {
            Tmcoenvremisiones = new HashSet<Tmcoenvremisione>();
        }

        public int IdStatus { get; set; }
        public string Descripcion { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual ICollection<Tmcoenvremisione> Tmcoenvremisiones { get; set; }
    }
}
