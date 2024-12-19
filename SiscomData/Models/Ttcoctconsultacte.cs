using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttcoctconsultacte
    {
        public int Id { get; set; }
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Numext { get; set; }
        public string Colonia { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public decimal LimiteCredito { get; set; }
        public bool Suspendido { get; set; }
        public decimal Saldo { get; set; }
        public string CalleEntrega { get; set; }
        public string ColoniaEntrega { get; set; }
        public string Afiliacion { get; set; }
        public string Usuario { get; set; }
    }
}
