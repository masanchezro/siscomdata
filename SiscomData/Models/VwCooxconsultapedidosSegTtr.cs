using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxconsultapedidosSegTtr
    {
        public DateTime FechaRuteo { get; set; }
        public int Pedido { get; set; }
        public string Servicio { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cancelado { get; set; }
        public string FormaPago { get; set; }
        public string Prioridad { get; set; }
        public int? Ruta { get; set; }
        public int Recetas { get; set; }
        public decimal ImporteRecetas { get; set; }
        public string Observaciones { get; set; }
        public int? CodigoPostal { get; set; }
        public string UsuarioCancela { get; set; }
        public string Usuario { get; set; }
        public string Chofer { get; set; }
        public string Unidad { get; set; }
        public string Ruteado { get; set; }
        public string SubTipo { get; set; }
        public string DireccionEnt { get; set; }
        public int? TipoEquipo { get; set; }
        public string TipoEquipoDesc { get; set; }
        public string MarcaAlmacen { get; set; }
        public bool? VolanteImpreso { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
    }
}
