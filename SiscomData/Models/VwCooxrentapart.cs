using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCooxrentapart
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public DateTime? FechaUltRenta { get; set; }
        public int CodigoEnvases { get; set; }
        public int DotacionFinal { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public int FolioFactura { get; set; }
        public int FolioAltaRenta { get; set; }
        public string DescProd { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioEspecial { get; set; }
        public int? Cilindros { get; set; }
        public string FechaDia { get; set; }
        public bool Cancelado { get; set; }
        public DateTime FechaBaja { get; set; }
        public int FolioBaja { get; set; }
        public int FormaPago { get; set; }
        public int CteFirma { get; set; }
        public bool ImprimirFactura { get; set; }
        public string ExentoRenta { get; set; }
        public string NombreCte { get; set; }
        public string Rfc { get; set; }
        public string Cedula { get; set; }
        public string Clave { get; set; }
        public DateTime FechaAlta { get; set; }
        public string TipoParticular { get; set; }
        public int? Dias { get; set; }
    }
}
