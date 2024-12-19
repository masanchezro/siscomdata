using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinsolrechazo
    {
        public int IdSolRechazo { get; set; }
        public int? Sucursal { get; set; }
        public string Remision { get; set; }
        public string Serie { get; set; }
        public int? Codigo { get; set; }
        public string Pedido { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Dcorrecto { get; set; }
        public decimal? CantidadFacProv { get; set; }
        public int? NoCliente { get; set; }
        public int? NoClienteInfra { get; set; }
        public string Observaciones { get; set; }
        public string IdMotRechazo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public bool? Transmitir { get; set; }
        public bool? Concluida { get; set; }
        public bool? Autorizado { get; set; }
        public bool? Revocada { get; set; }
        public DateTime? FechaCostos { get; set; }
        public string UsuarioResCostos { get; set; }
        public string ObsResCostos { get; set; }
        public string SolPdf { get; set; }
    }
}
