using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinpedidosmovil
    {
        public string Serie { get; set; }
        public int Folio { get; set; }
        public DateTime FechaRecibo { get; set; }
        public int NoCliente { get; set; }
        public int SucursalReparte { get; set; }
        public int SucursalFactura { get; set; }
        public int Codigo { get; set; }
        public decimal? Cantidad { get; set; }
        public string NivelInicial { get; set; }
        public string NivelFinal { get; set; }
        public string PresionInicial { get; set; }
        public string PresionFinal { get; set; }
        public string Unidad { get; set; }
        public string Placas { get; set; }
        public string NombreRepartidor { get; set; }
        public string Estatus { get; set; }
        public string Version { get; set; }
        public int? FolioS03 { get; set; }
        public int? FolioE03 { get; set; }
        public int? FolioFactura { get; set; }
        public bool? Transmitir { get; set; }
        public short? CteEntrega { get; set; }
        public DateTime? FechaFactura { get; set; }
        public string UsuarioFactura { get; set; }
    }
}
