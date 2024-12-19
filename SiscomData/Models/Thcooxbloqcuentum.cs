using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcooxbloqcuentum
    {
        public int HistorialId { get; set; }
        public DateTime Fecha { get; set; }
        public bool Bloqueo { get; set; }
        public int IdClienteOx { get; set; }
        public int ClienteFirma { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimiteCredito { get; set; }
        public string Usuario { get; set; }
        public int? Sucursal { get; set; }
        public bool Estatus { get; set; }
    }
}
