using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocacominter
    {
        public int IdPago { get; set; }
        public int? Sucursal { get; set; }
        public string SerieSuc { get; set; }
        public string FechaPago { get; set; }
        public int? SucAplica { get; set; }
        public int? Cliente { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public int? Folio { get; set; }
        public string ReferenciaPago { get; set; }
        public string Uuid { get; set; }
        public decimal? ImporteFactura { get; set; }
        public decimal? ImportePago { get; set; }
        public decimal? ImporteAplicado { get; set; }
        public string TipoPago { get; set; }
        public int? IdBanco { get; set; }
        public string RfcbancoCte { get; set; }
        public string CtaPagoCte { get; set; }
        public string RfcbancoBen { get; set; }
        public string RazonSocialBancoBen { get; set; }
        public string CtaBancoBen { get; set; }
        public string SerieFactura { get; set; }
        public int? FolioComplemento { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
