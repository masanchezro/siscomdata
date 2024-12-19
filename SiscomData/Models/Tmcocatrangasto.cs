using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocatrangasto
    {
        public int IdTransferencia { get; set; }
        public short Sucursal { get; set; }
        public string TipoCcsap { get; set; }
        public string Cuenta { get; set; }
        public short ContadorCta { get; set; }
        public decimal Transferencia { get; set; }
        public bool Activo { get; set; }
        public bool AceptaSobrante { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int Empleado { get; set; }
        public string Descripcion { get; set; }
        public decimal? CantidadComprobada { get; set; }
        public DateTime? FechaComprobacion { get; set; }
        public string UsuarioComprobacion { get; set; }
        public long? IdGlobalTran { get; set; }
        public string UsuarioCancela { get; set; }
        public DateTime? FechaCancela { get; set; }

        public virtual Tccocacuentagasto Tccocacuentagasto { get; set; }
    }
}
