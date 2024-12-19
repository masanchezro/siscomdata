using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCoencambioga
    {
        public int Recibo { get; set; }
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSuc { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaMov { get; set; }
        public int CodigoRec { get; set; }
        public string DesCodigoRec { get; set; }
        public short Envases { get; set; }
        public int? CodigoEnt { get; set; }
        public string DesCodigoEnt { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
    }
}
