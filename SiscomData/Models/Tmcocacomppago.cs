using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocacomppago
    {
        public Tmcocacomppago()
        {
            Tdcocacomppagos = new HashSet<Tdcocacomppago>();
        }

        public string ComVersion { get; set; }
        public string ComEtiquetaComplemento { get; set; }
        public string ComTipoDocumento { get; set; }
        public string ComTipoDocumentoEmpresa { get; set; }
        public string ComSerie { get; set; }
        public int ComFolio { get; set; }
        public string ComNoCertificado { get; set; }
        public string ComSubtotal { get; set; }
        public string ComTotal { get; set; }
        public string PagVersion { get; set; }
        public DateTime? PagFechaPago { get; set; }
        public string PagFormaDePagoP { get; set; }
        public string PagMonedaP { get; set; }
        public string PagTipoCambioP { get; set; }
        public string PagNumeroOperacion { get; set; }
        public decimal? PagMonto { get; set; }
        public string PagRfcemisorCtaOrd { get; set; }
        public string PagNomBancoOrdEx { get; set; }
        public string PagCtaOrdenante { get; set; }
        public string PagRfcemisorCtaBen { get; set; }
        public string PagNomBancoBen { get; set; }
        public string PagCtaBeneficiario { get; set; }
        public string PagTipoCadPago { get; set; }
        public string PagCertPago { get; set; }
        public string PagCadPago { get; set; }
        public string PagSelloPago { get; set; }
        public decimal? ImpTotalDeImpuestosRetenidos { get; set; }
        public decimal? ImpTotalDeImpuestosTrasladados { get; set; }
        public string PagRazonSocialEmisor { get; set; }
        public string PagRfcEmisor { get; set; }
        public string PagRegimen { get; set; }
        public string PagRegimenFiscal { get; set; }
        public string PagRazonSocialReceptor { get; set; }
        public string PagRfcReceptor { get; set; }
        public string PagUsoCfdi { get; set; }
        public string PagEmailReceptor { get; set; }
        public string PagLugarExpedicionSat { get; set; }
        public string PagLugarExpedicionGrafico { get; set; }
        public string PagAmbiente { get; set; }
        public string GraTipoDocumentoGra { get; set; }
        public string GraIfai { get; set; }
        public string GraFechaImpresaDelDocumento { get; set; }
        public string GraLeyenda1 { get; set; }
        public string GraLeyenda2 { get; set; }
        public string GrlImpresora { get; set; }
        public string GrlReimprime { get; set; }
        public string GrlUsuarioRealizoDocumento { get; set; }
        public short? GrlCopias { get; set; }
        public string GrlTipoAddenda { get; set; }
        public string GrlNombreAddenda { get; set; }
        public string Procesado { get; set; }
        public string ReferenciaInterna { get; set; }
        public string TipoComplemento { get; set; }
        public int? IdBancoComplemento { get; set; }
        public DateTime? FechaProcesado { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
        public string ComRelacionado { get; set; }
        public string ComUuidRelacion { get; set; }
        public string ComTipoRelacion { get; set; }
        public string ComDomicilioFiscalReceptor { get; set; }
        public string ComRegimenFiscalReceptor { get; set; }

        public virtual ICollection<Tdcocacomppago> Tdcocacomppagos { get; set; }
    }
}
