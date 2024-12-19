using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoidventasdeldium
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Cliente { get; set; }
        public int FolioControl { get; set; }
        public int Folio { get; set; }
        public decimal Credito { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Cheque { get; set; }
        public decimal Tarjeta { get; set; }
        public decimal Transferencia { get; set; }
        public string Usuario { get; set; }
        public string Reparto { get; set; }
        public string NombreCliente { get; set; }
        public decimal TipoCambio { get; set; }
        public string TipoFacturacion { get; set; }
        public string Banco { get; set; }
        public string NoPago { get; set; }
    }
}
