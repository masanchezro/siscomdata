using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class RespaldoEdithcar
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public int Folio { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime FechaMov { get; set; }
        public string Uuid { get; set; }
        public string MetodoPago { get; set; }
    }
}
