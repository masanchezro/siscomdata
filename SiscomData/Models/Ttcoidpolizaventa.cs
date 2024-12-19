using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoidpolizaventa
    {
        public int Id { get; set; }
        public string PolizaCuenta { get; set; }
        public short? Almacen { get; set; }
        public string TipoMovimiento { get; set; }
        public int? TipoIva { get; set; }
        public int? ClienteSuc { get; set; }
        public string CondicionPago { get; set; }
        public decimal? Tipocambio { get; set; }
        public string Retencion { get; set; }
        public string Descripcion { get; set; }
        public string TipoCliente { get; set; }
        public string ClavePoliza { get; set; }
        public short? Lineavta { get; set; }
        public string CuentaOxidom { get; set; }
        public string FaltaSap { get; set; }
        public string Indicador { get; set; }
        public string Exportaciones { get; set; }
        public decimal? ImporteContado { get; set; }
        public decimal? Importecredito { get; set; }
        public decimal? TotalImporteContado { get; set; }
        public decimal? TotalImporteCredito { get; set; }
        public decimal? TotalIvaContado { get; set; }
        public decimal? TotalIvaCredito { get; set; }
        public decimal? TasaIva { get; set; }
    }
}
