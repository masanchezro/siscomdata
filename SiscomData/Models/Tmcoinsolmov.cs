using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tmcoinsolmov
    {
        public int IdSol { get; set; }
        public short Sucursal { get; set; }
        public string TipoMovimiento { get; set; }
        public int Codigo { get; set; }
        public string Cuenta { get; set; }
        public decimal? Cantidad { get; set; }
        public int Motivo { get; set; }
        public bool Transmitir { get; set; }
        public bool Concluida { get; set; }
        public bool Autorizada { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public string Observaciones { get; set; }
    }
}
