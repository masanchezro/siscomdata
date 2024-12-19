using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoctremisionesfact
    {
        public int Remision { get; set; }
        public int? FolioPedido { get; set; }
        public string OrdenCompra { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal CantRemision { get; set; }
        public decimal CantFacturada { get; set; }
        public decimal CantDevuelta { get; set; }
        public int Cliente { get; set; }
        public string RazonSocial { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public int EnvasesRemision { get; set; }
        public decimal KilosLiquido { get; set; }
        public decimal Factor { get; set; }
        public int ClienteFactura { get; set; }
        public decimal M3carga { get; set; }
        public int? Factura { get; set; }
    }
}
