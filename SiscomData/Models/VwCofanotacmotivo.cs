using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofanotacmotivo
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public int NotaCredito { get; set; }
        public decimal? ImpTotal { get; set; }
        public int Factura { get; set; }
        public decimal ImpTotalFac { get; set; }
        public string TipoMotivo { get; set; }
        public string NombreMotivo { get; set; }
        public string NombreSubMotivo { get; set; }
        public string TipoPago { get; set; }
        public string DesPago { get; set; }
        public DateTime? FechaFac { get; set; }
        public DateTime? FechaFe { get; set; }
        public string Usuario { get; set; }
    }
}
