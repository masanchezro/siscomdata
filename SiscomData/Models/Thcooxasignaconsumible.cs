using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxasignaconsumible
    {
        public long IdAsignacion { get; set; }
        public int Sucursal { get; set; }
        public int Operador { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public decimal CantidadAsignada { get; set; }
        public string TipoMovimiento { get; set; }
        public int FolioMov { get; set; }
        public DateTime FechaMov { get; set; }
        public bool EntregadoAntes { get; set; }
        public long IdConsecutivoMov { get; set; }
        public long? IdPrimeraAsignacion { get; set; }
        public long? IdUltimaAsignacion { get; set; }
        public string Usuario { get; set; }
        public int? Almacen { get; set; }
        public int? Pedido { get; set; }
        public decimal? CantidadGratis { get; set; }
        public decimal? CantidadFacturada { get; set; }
    }
}
