using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcotrrecibepedido
    {
        public short? SucursalOrigen { get; set; }
        public short? Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int? Folio { get; set; }
        public int? Cliente { get; set; }
        public DateTime? FechaFe { get; set; }
        public string TipoBo { get; set; }
        public string NombreRuta { get; set; }
        public bool? BackOrder { get; set; }
        public int? TiempoEntrega { get; set; }
        public string CancelaDescto { get; set; }
        public bool? Procesado { get; set; }
    }
}
