using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TtaumentoArgon220926Borrar
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string TipoCte { get; set; }
        public int? SubTipoCte { get; set; }
        public string TipoAumento { get; set; }
        public int Codigo { get; set; }
        public decimal? PrecioActual { get; set; }
        public decimal? PrecioAnterior { get; set; }
        public string Moneda { get; set; }
        public bool Estatus { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public decimal? PrecioActualNvo { get; set; }
        public decimal? PrecioAnteriorNvo { get; set; }
        public bool EstatusNvo { get; set; }
        public string UsuarioNvo { get; set; }
        public DateTime FechaAuditNvo { get; set; }
    }
}
