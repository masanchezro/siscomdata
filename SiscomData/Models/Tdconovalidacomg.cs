using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tdconovalidacomg
    {
        public string TipoPago { get; set; }
        public string Fecha { get; set; }
        public int SucDestino { get; set; }
        public short SucOrigen { get; set; }
        public int Nomina { get; set; }
        public int Cliente { get; set; }
        public int Gas { get; set; }
        public int? FolioFactura { get; set; }
        public int? Cargas { get; set; }
        public decimal? Valores { get; set; }
        public int Cargas1 { get; set; }
        public decimal Valores1 { get; set; }
        public int Cargas2 { get; set; }
        public decimal Valores2 { get; set; }
        public int Cargas3 { get; set; }
        public decimal Valores3 { get; set; }
        public int? Porcentaje { get; set; }
        public int PorcentajeComision { get; set; }
        public decimal? Comision { get; set; }
        public int MesProceso { get; set; }
        public int AnioProceso { get; set; }
        public bool Pagar { get; set; }
        public bool Transmitir { get; set; }
        public bool Retransmitir { get; set; }
        public DateTime? FechaAudit { get; set; }
        public DateTime? FechaAlta { get; set; }
        public decimal? ComisionInicial { get; set; }
        public decimal? ComisionSubsecuente { get; set; }
        public string NombreSucursal { get; set; }
        public string Empleado { get; set; }
        public string NombreCliente { get; set; }
        public string Descripcion { get; set; }
        public bool Validar { get; set; }
        public DateTime? FechaValidacion { get; set; }
    }
}
