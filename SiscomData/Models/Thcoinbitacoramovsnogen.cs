using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Thcoinbitacoramovsnogen
    {
        public long IdBitacora { get; set; }
        public long? IdConsecutivoMovNoGen { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaMov { get; set; }
        public int Almacen { get; set; }
        public int ClienteSuc { get; set; }
        public int Pedido { get; set; }
        public string FacturaRemision { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public string MensajeError { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string InnerException { get; set; }
        public bool? Enviado { get; set; }
    }
}
