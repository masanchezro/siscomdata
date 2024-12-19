using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Bcfkm01
    {
        public short Suc { get; set; }
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public short? LineaAgrupa { get; set; }
        public short? Linea { get; set; }
        public short? EnvCont { get; set; }
        public short? EnvProp { get; set; }
        public short? EnvProv { get; set; }
        public decimal? Deposito { get; set; }
        public DateTime? FechaUltConsumo { get; set; }
        public DateTime? FechaAltaEnvases { get; set; }
        public string ExentoCampana { get; set; }
        public DateTime? FechaBaja { get; set; }
        public short? CargasEne { get; set; }
        public short? CargasFeb { get; set; }
        public short? CargasMar { get; set; }
        public short? CargasAbr { get; set; }
        public short? CargasMay { get; set; }
        public short? CargasJun { get; set; }
        public short? CargasJul { get; set; }
        public short? CargasAgo { get; set; }
        public short? CargasSep { get; set; }
        public short? CargasOct { get; set; }
        public short? CargasNov { get; set; }
        public short? CargasDic { get; set; }
        public double? UniEne { get; set; }
        public double? UniFeb { get; set; }
        public double? UniMar { get; set; }
        public double? UniAbr { get; set; }
        public double? UniMay { get; set; }
        public double? UniJun { get; set; }
        public double? UniJul { get; set; }
        public double? UniAgo { get; set; }
        public double? UniSep { get; set; }
        public double? UniOct { get; set; }
        public double? UniNov { get; set; }
        public double? UniDic { get; set; }
        public double? ValEne { get; set; }
        public double? ValFeb { get; set; }
        public double? ValMar { get; set; }
        public double? ValAbr { get; set; }
        public double? ValMay { get; set; }
        public double? ValJun { get; set; }
        public double? ValJul { get; set; }
        public double? ValAgo { get; set; }
        public double? ValSep { get; set; }
        public double? ValOct { get; set; }
        public double? ValNov { get; set; }
        public double? ValDic { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public short? Envmgm { get; set; }
    }
}
