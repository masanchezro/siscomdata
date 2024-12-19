using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class TmcofamtroExt
    {
        public short Sucursal { get; set; }
        public string TipoDocumento { get; set; }
        public int Folio { get; set; }
        public int Cliente { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string MotivoClave { get; set; }
    }
}
