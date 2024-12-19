using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCortconcodigoga
    {
        public short Sucursal { get; set; }
        public DateTime? Fecharuteo { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string NombreProducto { get; set; }
        public int? Cilindros { get; set; }
        public string TipoFacturacion { get; set; }
    }
}
