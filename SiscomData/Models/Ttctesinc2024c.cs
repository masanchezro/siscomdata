using System;
using System.Collections.Generic;

#nullable disable

namespace SiscomData.Models
{
    public partial class Ttctesinc2024c
    {
        public short Sucursal { get; set; }
        public int Cliente { get; set; }
        public string Nombre { get; set; }
        public string Distribuidor { get; set; }
        public string Cteespecial { get; set; }
        public string Catgases { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Tipoprod { get; set; }
        public decimal? PorcInc { get; set; }
        public decimal Mostrador { get; set; }
        public decimal? PrecioActual { get; set; }
        public string Moneda { get; set; }
        public decimal? PrecioNvo { get; set; }
        public decimal? Precioanterior { get; set; }
        public DateTime Fechaaudit { get; set; }
        public string Usuario { get; set; }
        public bool Estatus { get; set; }
        public string Observaciones { get; set; }
    }
}
