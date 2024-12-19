using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocasolcontum
    {
        public short SucursalSolicita { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int NoDocumento { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal Importe { get; set; }
        public string Moneda { get; set; }
        public DateTime? FechaDeposito { get; set; }
        public decimal? MontoDeposito { get; set; }
        public string NombreBanco { get; set; }
        public string SucBanco { get; set; }
        public string Motivo { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }
        public bool Transmitir { get; set; }
        public bool Concluida { get; set; }
        public bool Autorizada { get; set; }
        public bool Revocada { get; set; }
        public DateTime? FechaAprobacionContabilidad { get; set; }
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int Id { get; set; }
        public string DocAdjunto { get; set; }
        public string ClabeInterbancaria { get; set; }
    }
}
