using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxejecutivo
    {
        public Tmcooxejecutivo()
        {
            Tmcooxcteejecutivos = new HashSet<Tmcooxcteejecutivo>();
        }

        public int Nomina { get; set; }
        public short Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime Antiguedad { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public short Activo { get; set; }

        public virtual Tccogrsuc SucursalNavigation { get; set; }
        public virtual ICollection<Tmcooxcteejecutivo> Tmcooxcteejecutivos { get; set; }
    }
}
