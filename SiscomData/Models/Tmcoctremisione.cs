using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoctremisione
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Remision { get; set; }
        public int Codigo { get; set; }
        public int? FolioPedido { get; set; }
        public DateTime Fecha { get; set; }
        public int EnvasesRemision { get; set; }
        public decimal CantRemision { get; set; }
        public decimal CantFacturada { get; set; }
        public decimal CantDevuelta { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public string OrdenCompra { get; set; }
        public decimal TipoCambio { get; set; }
        public int ClienteFactura { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int? Factura { get; set; }
        public int? EnvasesFacturados { get; set; }
        public int? Idcabecera { get; set; }
        public int? MesProceso { get; set; }
        public int? AñoProceso { get; set; }
        public string MotivoRetraso { get; set; }

        public virtual Tmcoinprod01 CodigoNavigation { get; set; }
    }
}
