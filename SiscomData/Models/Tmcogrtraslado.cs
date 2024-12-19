using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcogrtraslado
    {
        public int Id { get; set; }
        public short? Sucursal { get; set; }
        public string TipoMovimiento { get; set; }
        public int? Folio { get; set; }
        public int? Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public int? ClienteSuc { get; set; }
        public int? Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public DateTime? FechaMov { get; set; }
        public string TipoCaptura { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string CodigoP { get; set; }
        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string CodigoCol { get; set; }
        public bool? LlenoVacio { get; set; }
    }
}
