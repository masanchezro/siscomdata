using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Tccooxcodigosfactura
    {
        public short Sucursal { get; set; }
        public int IdClientesOx { get; set; }
        public int CodigoFacturar { get; set; }
        public int FamiliaServicio { get; set; }
        public bool Estatus { get; set; }
        public DateTime FechaAudit { get; set; }
        public string Usuario { get; set; }
        public string Tipo { get; set; }
    }
}
