using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCofaconsumoscte
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public string FechaUltConsumo { get; set; }
        public int? Ene { get; set; }
        public int? Feb { get; set; }
        public int? Mar { get; set; }
        public int? Abr { get; set; }
        public int? May { get; set; }
        public int? Jun { get; set; }
        public int? Jul { get; set; }
        public int? Ago { get; set; }
        public int? Sep { get; set; }
        public int? Oct { get; set; }
        public int? Nov { get; set; }
        public int? Dic { get; set; }
        public decimal SugEne { get; set; }
        public decimal SugFeb { get; set; }
        public decimal SugMar { get; set; }
        public decimal? SugAbr { get; set; }
        public decimal? SugMay { get; set; }
        public decimal? SugJun { get; set; }
        public decimal? SugJul { get; set; }
        public decimal? SugAgo { get; set; }
        public decimal? SugSep { get; set; }
        public decimal? SugOct { get; set; }
        public decimal? SugNov { get; set; }
        public decimal? SugDic { get; set; }
    }
}
