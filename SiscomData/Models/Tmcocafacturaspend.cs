using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocafacturaspend
    {
        public int Sucursal { get; set; }
        public int Cliente { get; set; }
        public int FolioFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal Importe { get; set; }
        public string Departamento { get; set; }
        public string Status { get; set; }
        public int? Liberada { get; set; }
        public int? Cancelada { get; set; }
        public string TipoMovimiento { get; set; }
        public int? Ejecutivo { get; set; }
        public int? NumPromotora { get; set; }
        public string Usuario { get; set; }
        public short? ZonaCobro { get; set; }
        public string NombrePromotora { get; set; }
        public int? Dias { get; set; }
        public decimal? Saldo { get; set; }
        public int? SucursalOrigen { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public DateTime? FechaLiberacion { get; set; }
        public string EsCredito { get; set; }
        public string Observaciones { get; set; }
        public string ObsCredito { get; set; }
    }
}
