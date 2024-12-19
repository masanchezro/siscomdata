using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxpedidospendientesttr
    {
        public short Sucursal { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaRuteo { get; set; }
        public int Cliente { get; set; }
        public string NombrePaciente { get; set; }
        public int TipoServicio { get; set; }
        public string DescTipoServicio { get; set; }
        public int? NominaTtr { get; set; }
        public string NombreEmp { get; set; }
        public string PrioridadServicio { get; set; }
        public int? Ruta { get; set; }
        public int? TipoEquipo { get; set; }
        public string AsignaTtr { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Contrato { get; set; }
        public int Propiedad { get; set; }
        public string TipoProd { get; set; }
    }
}
