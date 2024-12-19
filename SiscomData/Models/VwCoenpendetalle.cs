using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenpendetalle
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public int Recibo { get; set; }
        public short? SucOrigen { get; set; }
        public DateTime? Fecha { get; set; }
        public int Codigo { get; set; }
        public string DesCodigo { get; set; }
        public short? Envases { get; set; }
        public bool? EstatusEntrega { get; set; }
    }
}
