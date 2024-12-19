using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoinprod
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string NumeroDeParte { get; set; }
        public decimal? EmpVenta { get; set; }
        public short LineaVta { get; set; }
        public short LineaAgrupa { get; set; }
        public int AgrupaExistencia { get; set; }
        public decimal Precio { get; set; }
        public decimal? PrecioAnterior { get; set; }
        public decimal? PrecioMostrador { get; set; }
        public decimal PrecioPiso { get; set; }
        public DateTime? FechaCambioPrecio { get; set; }
        public string UnidadDeMedida { get; set; }
        public int TipoProd { get; set; }
        public string TipoProducto { get; set; }
        public string TipoEnvase { get; set; }
        public string SubTipoEnv { get; set; }
        public string ValvulaEnv { get; set; }
        public decimal? Capacidad { get; set; }
        public short? TiempoEntrega { get; set; }
        public int? CodigoElectrodos { get; set; }
        public int Proveedor { get; set; }
        public string Clasificacion { get; set; }
        public string Origen { get; set; }
        public decimal? EmpaqueSuc { get; set; }
        public decimal? EmpaqueProv { get; set; }
        public decimal? MaximoAnterior { get; set; }
        public decimal? Maximo { get; set; }
        public decimal? Minimo { get; set; }
        public short? Factor { get; set; }
        public decimal Existencia { get; set; }
        public decimal ApartadoFacturacion { get; set; }
        public decimal ApartadoSucursal { get; set; }
        public decimal Backorder { get; set; }
        public short Almacen { get; set; }
        public DateTime? FechaUltimoConsumo { get; set; }
        public string CveOxidom { get; set; }
        public string DescCveOxidom { get; set; }
        public string JerarquiaSap { get; set; }
        public string Material { get; set; }
        public string NaturalezaQuim { get; set; }
        public string Tecnologia { get; set; }
    }
}
