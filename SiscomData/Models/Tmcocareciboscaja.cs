using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcocareciboscaja
    {
        public int Compañia { get; set; }
        public int Folio { get; set; }
        public string Cuenta { get; set; }
        public int Referencia { get; set; }
        public int Sucursal { get; set; }
        public int? Cliente { get; set; }
        public decimal Importe { get; set; }
        public bool Cancelado { get; set; }
        public string Recibimos { get; set; }
        public string Concepto { get; set; }
        public string TipoPago { get; set; }
        public string NoPago { get; set; }
        public int IdBanco { get; set; }
        public string ClaveContabilidad { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaAudit { get; set; }
        public string TipoMovimiento { get; set; }
    }
}
