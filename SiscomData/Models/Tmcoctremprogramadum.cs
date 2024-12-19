using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctremprogramadum
    {
        public int Id { get; set; }
        public int SucursalOrigen { get; set; }
        public int SucursalDestino { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public decimal CantidadProgramada { get; set; }
        public DateTime FechaProgramada { get; set; }
        public int? Remision { get; set; }
        public DateTime? FechaRemision { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool Cancelado { get; set; }
        public bool GeneraRemision { get; set; }
        public bool GeneraTraspaso { get; set; }
        public int? FolioSalida { get; set; }
        public int? FolioEntrada { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public int? IdDireccion { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string UsuarioModificador { get; set; }
    }
}
