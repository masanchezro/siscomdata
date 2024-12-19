using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoenmov
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Recibo { get; set; }
        public int FolioDep { get; set; }
        public DateTime FechaMov { get; set; }
        public DateTime? FechaPago { get; set; }
        public string Entrga { get; set; }
        public short? Contrato { get; set; }
        public short? Propiedad { get; set; }
        public short? Provisional { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Saldo { get; set; }
        public short? SucOrigen { get; set; }
        public string MovCorp { get; set; }
        public string TipoMovimiento { get; set; }
        public string Movimiento { get; set; }
        public int ReciboCorpo { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
    }
}
