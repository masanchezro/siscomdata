using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpedido
    {
        public short Sucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Pedido { get; set; }
        public int Cliente { get; set; }
        public string Descripcion { get; set; }
        public string PrioridadServicio { get; set; }
        public string FormaPago { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Recetas { get; set; }
        public decimal ImporteRecetas { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public int Contrato { get; set; }
        public string Telefono1 { get; set; }
        public string Codpos { get; set; }
        public string Nombre { get; set; }
        public int Factura { get; set; }
        public int Ruta { get; set; }
        public string TipoCte { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
