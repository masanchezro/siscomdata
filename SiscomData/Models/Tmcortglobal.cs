using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcortglobal
    {
        public short Sucursal { get; set; }
        public DateTime FechaCarga { get; set; }
        public string TipoRuteoOrg { get; set; }
        public int? IdAsignacionViaje { get; set; }
        public int Numero { get; set; }
        public int? EntregasMovil { get; set; }
        public string Movil { get; set; }
        public string Zona { get; set; }
        public string RutaEntrega { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int? Ubicación { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public string Dirección { get; set; }
        public string Cilindros { get; set; }
        public int? CilindrosCantidad { get; set; }
        public string Mercancias { get; set; }
        public int? MercanciasCantidad { get; set; }
        public string PesoMercancia { get; set; }
        public decimal? MercanciaCantidadPeso { get; set; }
        public string Servicios { get; set; }
        public int? ServiciosCantidad { get; set; }
        public string FechaVisita { get; set; }
        public int? GeoInicio { get; set; }
        public string TipoUnidad { get; set; }
        public int? Pedido { get; set; }
        public int? Factura { get; set; }
        public string TipoRuteo { get; set; }
        public string TipoOperacion { get; set; }
        public string HoraEntregaMinimo { get; set; }
        public string HoraEntregaMaximo { get; set; }
        public int? Duración { get; set; }
        public string Ruteado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
