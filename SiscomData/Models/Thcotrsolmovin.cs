using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcotrsolmovin
    {
        public long Id { get; set; }
        public string IdSolicitud { get; set; }
        public string Sucursal { get; set; }
        public string TipoMovimiento { get; set; }
        public string Codigo { get; set; }
        public string Ccsap { get; set; }
        public string Cantidad { get; set; }
        public string IdMotivo { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public string Autorizado { get; set; }
        public string FechaRespuesta { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
        public string FechaCarga { get; set; }
    }
}
