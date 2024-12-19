using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinfisico
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Marbete { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public short Linea { get; set; }
        public string Um { get; set; }
        public decimal Precio { get; set; }
        public decimal? ExistenciaTeorica { get; set; }
        public decimal? ExistenciaFisica { get; set; }
        public decimal? Diferencia { get; set; }
        public DateTime? FechaInventario { get; set; }
        public string TipoMov { get; set; }
        public string Movimiento { get; set; }
        public int? TipoProd { get; set; }
        public bool? Capturado { get; set; }
        public bool? Activo { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
