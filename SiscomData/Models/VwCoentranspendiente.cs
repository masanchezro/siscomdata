using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoentranspendiente
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Recibo { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string TipoMovimiento { get; set; }
        public string Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string FechaMov { get; set; }
        public int Codigo { get; set; }
        public string DesCodigo { get; set; }
        public short? Envases { get; set; }
        public decimal? Importe { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string Usuario { get; set; }
    }
}
