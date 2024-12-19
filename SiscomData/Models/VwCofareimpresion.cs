using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofareimpresion
    {
        public bool? Seleccion { get; set; }
        public int Folio { get; set; }
        public string TipoDocumento { get; set; }
        public short? Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public decimal? TotalFacturaPesos { get; set; }
        public DateTime? FechaFe { get; set; }
        public bool? Xmlenviado { get; set; }
    }
}
