using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencontrato
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Rfc { get; set; }
        public string TipoCte { get; set; }
        public string RespInfra { get; set; }
        public string PtoInfra { get; set; }
        public string RespCte { get; set; }
        public string PtoCte { get; set; }
        public string IdentificacionCte { get; set; }
        public string Giro { get; set; }
        public string DireccionFiscal { get; set; }
        public string TipoSociedad { get; set; }
        public string Plazo { get; set; }
        public string Folios { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaAudit { get; set; }
    }
}
