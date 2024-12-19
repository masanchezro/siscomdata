using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoidcierre
    {
        public int Id { get; set; }
        public int Sucursal { get; set; }
        public int Caja { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public string MetodoPago { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public string Asignacion { get; set; }
        public string OrdenInterna { get; set; }
        public string TipoCuenta { get; set; }
        public string FechaBase { get; set; }
        public string Ccsap { get; set; }
        public string Cbsap { get; set; }
        public string ClaveMon { get; set; }
        public decimal? Importe { get; set; }
        public string IndicadorIva { get; set; }
        public string TipoImporte { get; set; }
        public int? Banco { get; set; }
        public string RefBanco { get; set; }
        public string UsarPoliza { get; set; }
        public string Usuario { get; set; }
        public string DescPartida { get; set; }
        public string ClaseAux { get; set; }
    }
}
