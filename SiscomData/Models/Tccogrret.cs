using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccogrret
    {
        public string IdRetencion { get; set; }
        public string NombreRetencion { get; set; }
        public string Descripcion { get; set; }
        public decimal? Porcentaje { get; set; }
        public bool? RetencionIva { get; set; }
        public bool? VisibleClientes { get; set; }
        public int? CodigoRetencion { get; set; }
        public string LeyendaRetencion { get; set; }
    }
}
