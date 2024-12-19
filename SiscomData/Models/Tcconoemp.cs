using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tcconoemp
    {
        public Tcconoemp()
        {
            Tcconoejes = new HashSet<Tcconoeje>();
            Tdconocomgs = new HashSet<Tdconocomg>();
            Tmcoctsolpreesps = new HashSet<Tmcoctsolpreesp>();
        }

        public short Sucursal { get; set; }
        public int Nomina { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }
        public string Nick { get; set; }
        public bool AnticipoGastos { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }

        public virtual Tccogrsuc SucursalNavigation { get; set; }
        public virtual Tccocaempanticipo Tccocaempanticipo { get; set; }
        public virtual ICollection<Tcconoeje> Tcconoejes { get; set; }
        public virtual ICollection<Tdconocomg> Tdconocomgs { get; set; }
        public virtual ICollection<Tmcoctsolpreesp> Tmcoctsolpreesps { get; set; }
    }
}
