using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxcobrostcarchivo
    {
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Codigo { get; set; }
        public int Sucursal { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public string NoTarjeta { get; set; }
        public double? Importe { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int DiasRenta { get; set; }
        public int Dot { get; set; }
        public string Auto { get; set; }
        public int Factura { get; set; }
        public string ArchivoSalida { get; set; }
        public string Rfc { get; set; }
        public string CodigoAuto { get; set; }
    }
}
