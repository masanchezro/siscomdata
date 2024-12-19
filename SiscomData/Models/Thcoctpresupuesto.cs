using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoctpresupuesto
    {
        public short Sucursal { get; set; }
        public short Mes { get; set; }
        public string NombreMes { get; set; }
        public int Presupuesto { get; set; }
        public int RealCtes { get; set; }
        public int PresupuestoAcu { get; set; }
        public int RealAcu { get; set; }
        public int CtesOxi { get; set; }
        public int CtesOxiAcu { get; set; }
    }
}
