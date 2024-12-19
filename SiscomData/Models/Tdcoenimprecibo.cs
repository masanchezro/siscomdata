using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdcoenimprecibo
    {
        public int Recibo { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSuc { get; set; }
        public int Cliente { get; set; }
        public string NombreCte { get; set; }
        public string Rfc { get; set; }
        public string DireccionCte { get; set; }
        public string Movimiento { get; set; }
        public int Codigo { get; set; }
        public string DescripcionCodigo { get; set; }
        public string TipoEnvase { get; set; }
        public int? Envases { get; set; }
        public decimal? Importe { get; set; }
        public string Observaciones { get; set; }
        public string FirmaCte { get; set; }
        public string FirmaFacturista { get; set; }
        public string FirmaEncargado { get; set; }
        public string FirmaGerente { get; set; }
        public string DireccionEntrega { get; set; }
        public string FormaPago { get; set; }
        public int? RecoboDeposito { get; set; }
        public string ObservacionesGral { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Cancelado { get; set; }
        public string Estatus { get; set; }
    }
}
