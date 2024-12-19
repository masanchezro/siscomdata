using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCopdtiempoentrega
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string CodigoPostal { get; set; }
        public short Ruta { get; set; }
        public string PedidoFactura { get; set; }
        public DateTime? FechaFe { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string NombreProducto { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public short LineaVta { get; set; }
        public string TipoProd { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public short? TiempoEnt { get; set; }
    }
}
