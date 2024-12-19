using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoidpolizasap
    {
        public int UniqueId { get; set; }
        public string LdrEntityId { get; set; }
        public string Ctasap { get; set; }
        public string Ccsap { get; set; }
        public decimal? Saldo { get; set; }
        public string Referencia { get; set; }
        public string Fechadoc { get; set; }
        public string Fechacon { get; set; }
        public string Clasedoc { get; set; }
        public string Moneda { get; set; }
        public decimal Tipocambio { get; set; }
        public string Descripcion { get; set; }
        public string Indicadoriva { get; set; }
        public string Fechavalor { get; set; }
        public string CargoAbono { get; set; }
        public string ClaveContable { get; set; }
        public string IndicadorCme { get; set; }
        public decimal Baseretencion { get; set; }
        public decimal ExentoRetencion { get; set; }
        public string IndicadorRetencion { get; set; }
        public string OrdenInterna { get; set; }
        public string CondicionPago { get; set; }
        public string FechaBase { get; set; }
        public string BloqueoPago { get; set; }
        public int Cantidad { get; set; }
        public string Um { get; set; }
        public string Asignacion { get; set; }
        public string Cebe { get; set; }
        public string ContraPda { get; set; }
        public string CorteFactura { get; set; }
        public string TipoCarga { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
        public string Idenusd { get; set; }
        public decimal? ImpOriginal { get; set; }
        public decimal? ImpSucIva { get; set; }
    }
}
