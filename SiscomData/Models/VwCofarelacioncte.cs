using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofarelacioncte
    {
        public short Sucursal { get; set; }
        public int Folio { get; set; }
        public DateTime? FechaFe { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoFacturacion { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string DireccionCte { get; set; }
        public string CodigoPostal { get; set; }
        public short Ruta { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public string TipoRfc { get; set; }
        public string Pago { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FechaRuteo { get; set; }
    }
}
