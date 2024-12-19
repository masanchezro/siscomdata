using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoenmovsol
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Recibo { get; set; }
        public string Referencia { get; set; }
        public decimal Importe { get; set; }
        public decimal? Devolucion { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
