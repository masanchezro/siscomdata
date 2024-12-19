using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxconsultapedido
    {
        public int Pedido { get; set; }
        public string Descripcion { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Prioridad { get; set; }
        public bool Cancelado { get; set; }
        public DateTime FechaRuteo { get; set; }
        public bool Ruteado { get; set; }
        public bool Expr1 { get; set; }
        public string ObservacionesCancela { get; set; }
        public string UsuarioCancela { get; set; }
        public DateTime? FechaReactivacionEquipo { get; set; }
        public string ObservacionesReactivacion { get; set; }
        public bool Facturado { get; set; }
        public bool PendienteFacturacion { get; set; }
        public string FormaPago { get; set; }
        public string Observaciones { get; set; }
        public short Sucursal { get; set; }
        public int Recetas { get; set; }
        public decimal ImporteRecetas { get; set; }
        public decimal ImporteSee { get; set; }
        public int? Ruta { get; set; }
        public int? CodigoPostal { get; set; }
        public string Usuario { get; set; }
    }
}
