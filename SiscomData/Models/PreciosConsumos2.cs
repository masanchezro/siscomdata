using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class PreciosConsumos2
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precioespecialanterior { get; set; }
        public decimal? PrecioEspecial { get; set; }
        public decimal Precio { get; set; }
        public decimal? Preciomostrador { get; set; }
        public decimal Preciopiso { get; set; }
        public DateTime UltFechaModifPe { get; set; }
        public DateTime? Fechaconsumo { get; set; }
        public int TipoProducto { get; set; }
        public int? Diassinconsumo { get; set; }
        public int? DiasSinCambioPrecioEspecial { get; set; }
        public decimal Uni2017 { get; set; }
        public decimal Val2017 { get; set; }
        public decimal Uni2018 { get; set; }
        public decimal Val2018 { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaProceso { get; set; }
    }
}
