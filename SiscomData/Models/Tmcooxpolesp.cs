using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcooxpolesp
    {
        public int Idpolesp { get; set; }
        public int? Sucursal { get; set; }
        public int? Codigo { get; set; }
        public string Accion { get; set; }
        public string TipoAccion { get; set; }
        public string PrecioEspecial { get; set; }
        public string UsuarioSuc { get; set; }
        public DateTime? FechaSol { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public int? Cliente { get; set; }
        public int? Pedido { get; set; }
        public bool? Transmitir { get; set; }
        public bool? Solicitado { get; set; }
        public bool? Cancelado { get; set; }
        public bool? Autorizado { get; set; }
        public bool? Aplicado { get; set; }
    }
}
