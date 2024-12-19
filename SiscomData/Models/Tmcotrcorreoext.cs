using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcotrcorreoext
    {
        public int IdTransmite { get; set; }
        public short Intentos { get; set; }
        public DateTime? FechaSyncronizacion { get; set; }
        public DateTime? FechaError { get; set; }
        public string MensajeError { get; set; }
    }
}
