using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class VwCodmovenvase
    {
        public short Sucursal { get; set; }
        public short Ccsucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireccionSuc { get; set; }
        public int Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public int Recibo { get; set; }
        public string Movimiento { get; set; }
        public int Gas { get; set; }
        public string Descripcion { get; set; }
        public string MovEnvases { get; set; }
        public short Envases { get; set; }
        public string Observaciones { get; set; }
        public decimal Importe { get; set; }
        public int FolioDev { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
