using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocaantgasto
    {
        public int IdAnticipoGasto { get; set; }
        public short Sucursal { get; set; }
        public string TipoCcsap { get; set; }
        public string Cuenta { get; set; }
        public int Empleado { get; set; }
        public decimal Anticipo { get; set; }
        public string LugarViaje { get; set; }
        public DateTime InicioViaje { get; set; }
        public DateTime FinViaje { get; set; }
        public string MotivoViaje { get; set; }
        public bool Comprobado { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public decimal CantidadComprobada { get; set; }
    }
}
