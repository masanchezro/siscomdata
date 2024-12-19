using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccoidcaja
    {
        public int Sucursal { get; set; }
        public int Caja { get; set; }
        public string Descripcion { get; set; }
        public bool? Predeterminado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public decimal MontoCorte { get; set; }
        public int? TiempoDeCorte { get; set; }
        public string ResponsableCaja { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaUltCorte { get; set; }
        public string Corte { get; set; }
        public int? NoCorte { get; set; }
        public string UsuarioCorte { get; set; }
        public string NotificacionCorte { get; set; }
    }
}
