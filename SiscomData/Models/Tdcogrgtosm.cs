﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcogrgtosm
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int? DotacionTotal { get; set; }
        public int? Factura { get; set; }
        public DateTime? FechaFactura { get; set; }
        public int? CantidadFacturada { get; set; }
        public decimal? ImporteFacturado { get; set; }
        public string CvePago { get; set; }
        public string MotivoMovimiento { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
    }
}
