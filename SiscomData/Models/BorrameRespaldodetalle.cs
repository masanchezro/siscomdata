using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class BorrameRespaldodetalle
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public int Partida { get; set; }
        public int Codigo { get; set; }
        public string NombreProducto { get; set; }
        public string DetalleDescripcion { get; set; }
        public int? Cilindros { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? ImportePartida { get; set; }
        public decimal? SubtotalPartida { get; set; }
        public string Um { get; set; }
        public string NumeroContrato { get; set; }
        public decimal? Ivapartida { get; set; }
        public decimal? PorcentajeIva { get; set; }
    }
}
