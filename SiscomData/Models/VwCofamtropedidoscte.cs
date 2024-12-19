using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofamtropedidoscte
    {
        public short Sucursal { get; set; }
        public int Pedido { get; set; }
        public string FormaPago { get; set; }
        public string TipoDocumento { get; set; }
        public string DesTipoDocto { get; set; }
        public string TipoFacturacion { get; set; }
        public string TipoPedido { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string NombreClienteEntrega { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string NumInt { get; set; }
        public string NumExt { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Calle1 { get; set; }
        public string Calle2 { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public short Ruta { get; set; }
        public bool Reparto { get; set; }
        public short? Ejecutivo { get; set; }
        public string TipoPago { get; set; }
        public string DesTipoPago { get; set; }
        public string PedidoFactura { get; set; }
        public string TipoCampoAuxiliar { get; set; }
        public string Auxiliar1 { get; set; }
        public string Auxiliar2 { get; set; }
        public string Auxiliar3 { get; set; }
        public string Auxiliar4 { get; set; }
        public string Auxiliar5 { get; set; }
        public decimal TotalFacturaSinIva { get; set; }
        public decimal Totaldescuentos { get; set; }
        public decimal SubtotalSinIva { get; set; }
        public decimal Iva { get; set; }
        public decimal? Total { get; set; }
        public decimal TotalRetencion { get; set; }
        public string ClaveFacturacion { get; set; }
        public decimal TipoCambio { get; set; }
        public string Usuario { get; set; }
        public string ClaveAutorizacionSat { get; set; }
        public string NoOrdenCompra { get; set; }
        public DateTime? FechaFe { get; set; }
        public string FiltroRutas { get; set; }
        public string TourSolver1 { get; set; }
        public string TourSolver2 { get; set; }
        public bool? Xmlenviado { get; set; }
        public string ObservacionesPartidas { get; set; }
        public string ObservacionesPreCargadas { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaRuteo { get; set; }
        public string Estatus { get; set; }
        public decimal LimiteCredito { get; set; }
        public decimal Saldo { get; set; }
        public short ZonaCobro { get; set; }
        public string DiaRevision { get; set; }
        public string DiaCobro { get; set; }
        public string UsuarioPedido { get; set; }
    }
}
