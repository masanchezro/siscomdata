using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TccocacuentagastosResp
    {
        public short Sucursal { get; set; }
        public string TipoGasto { get; set; }
        public string Cuenta { get; set; }
        public short Contador { get; set; }
        public string Descripcion { get; set; }
        public string TipoSucAplica { get; set; }
        public string TipoccSap { get; set; }
        public string Referencia { get; set; }
        public decimal? PorcenRet1 { get; set; }
        public string CuentaRet1 { get; set; }
        public decimal? PorcenRet2 { get; set; }
        public string CuentaRet2 { get; set; }
        public decimal? TipoIva { get; set; }
        public bool Acumula { get; set; }
        public short? TipoOper { get; set; }
        public bool? SolicitaProv { get; set; }
        public string DescUsos { get; set; }
        public bool? CapturaDetalle { get; set; }
        public bool? Anticipo { get; set; }
        public string Vehiculo { get; set; }
        public bool Extraordinario { get; set; }
        public decimal EneP { get; set; }
        public decimal FebP { get; set; }
        public decimal MarP { get; set; }
        public decimal AbrP { get; set; }
        public decimal MayP { get; set; }
        public decimal JunP { get; set; }
        public decimal JulP { get; set; }
        public decimal AgoP { get; set; }
        public decimal SepP { get; set; }
        public decimal OctP { get; set; }
        public decimal NovP { get; set; }
        public decimal DicP { get; set; }
        public decimal EneR { get; set; }
        public decimal FebR { get; set; }
        public decimal MarR { get; set; }
        public decimal AbrR { get; set; }
        public decimal MayR { get; set; }
        public decimal JunR { get; set; }
        public decimal JulR { get; set; }
        public decimal AgoR { get; set; }
        public decimal SepR { get; set; }
        public decimal OctR { get; set; }
        public decimal NovR { get; set; }
        public decimal DicR { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public bool? ValidaXml { get; set; }
    }
}
